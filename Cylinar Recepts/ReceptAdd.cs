using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ReceptDb;

namespace Cylinar_Recepts
{
    public partial class ReceptAdd : Form
    {
        private User currentUser;
        private int receptId;

        //Конструктор Додавання рецепту
        public ReceptAdd(User user)
        {
            InitializeComponent();

            Text = "Додати рецепт";

            currentUser = user;
            receptId = 0;

            using (var context = new ReceptContext())
            {
                receptTypesBox.DataSource = context.ReceptTypes.ToList();
                receptTypesBox.ValueMember = "id";
                receptTypesBox.DisplayMember = "Name";
            }
        }

        //Конструкто редагування рецепту
        public ReceptAdd(User user, int receptId)
        {
            InitializeComponent();


            Text = "Редагування рецепту";


            this.receptId = receptId;
            currentUser = user;

            using (var context = new ReceptContext())
            {

                var recept = context.Recepts.Where(r => r.id == receptId).FirstOrDefault();

                if(recept != null)
                {
                    receptNameBox.Text = recept.Name;
                    receptDescBox.Text = recept.Description;


                    receptTypesBox.DataSource = context.ReceptTypes.ToList();
                    receptTypesBox.ValueMember = "id";
                    receptTypesBox.DisplayMember = "Name";

                    receptTypesBox.SelectedItem = recept.ReceptType;


                    var ingrds = recept.Ingredients.Join(
                        context.Units,
                        i => i.UnitId,
                        u => u.id,
                        (i, u) => new
                        {
                            Name = i.Name,
                            Count = i.Count,
                            Unit = u.id
                        }).ToList();

                    foreach (var i in ingrds)
                    {
                        ingredientsData.Rows.Add(i.Name, i.Count);

                        ingrUnit.DataSource = context.Units.ToList();
                        ingrUnit.ValueMember = "id";
                        ingrUnit.DisplayMember = "Name";

                        int currRow = ingredientsData.Rows.Count - 1;

                        ingredientsData.Rows[currRow].Cells["ingrUnit"].Value = i.Unit;

                    }
                }
            }
        }
       

        //Додавання нового рядка для інгредієнту
        private void addIngredient_Click(object sender, EventArgs e)
        {
            ingredientsData.Rows.Add();

            using (var context = new ReceptContext())
            {
                ingrUnit.DataSource = context.Units.ToList();
                ingrUnit.ValueMember = "id";
                ingrUnit.DisplayMember = "Name";
            }

        }

        //Видаленння рядка
        private void removeIngredient_Click(object sender, EventArgs e)
        {
            if(ingredientsData.SelectedCells.Count > 0)
            {
                int index = ingredientsData.SelectedCells[0].RowIndex;

                if (index != -1)
                {
                    try
                    {
                        ingredientsData.Rows.RemoveAt(index);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
        }
        //Закриття форми
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Введені дані не збережуться, всеодно вийти?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.No) return;

            Close();
        }

        //Створення нового рецепту
        private void receptCreate()
        {
            using (var context = new ReceptContext())
            {
                var type = (ReceptType)receptTypesBox.SelectedItem;

                if (string.IsNullOrWhiteSpace(receptNameBox.Text))
                {
                    MessageBox.Show("Вкажіть назву");
                    return;
                }

                if (string.IsNullOrWhiteSpace(receptDescBox.Text))
                {
                    MessageBox.Show("Вкажіть рецепт");
                    return;
                }

                var recept = new ReceptDb.Recept()
                {
                    Name = receptNameBox.Text.Trim(),
                    Description = receptDescBox.Text.Trim(),
                    UserId = currentUser.id,
                    ReceptTypeId = type.id
                };

                context.Recepts.Add(recept);

                var ingrds = GetIngredients(recept.id);


                if (ingrds.Count != 0)
                {
                    if(CheckProhibitedIngredient(recept, ingrds) == false)
                    {
                        context.Ingredients.AddRange(ingrds);
                        context.SaveChanges();
                        MessageBox.Show("Рецепт відправленно на модерацію");

                        Close();
                    }
                    else MessageBox.Show("Ваш рецепт містить заборонені інгредієнти");

                }
                else MessageBox.Show("Додайде інгредієнти");
            }
        }

        /// <summary>
        /// Перевірка на заборонені інгредієнти
        /// </summary>
        /// <param name="recept">Рецепт</param>
        /// <param name="ingredientList">Список інгредієнтів</param>
        /// <returns>True якщо не знайдено, False - знайдено</returns>
        private bool CheckProhibitedIngredient(ReceptDb.Recept recept, List<Ingredient> ingredientList)
        {

            using (var context = new ReceptContext())
            {

                var desc = recept.Description.ToLower().Split(' ');

                foreach (var prohibitedIngrd in context.ProhibitedIngredients.ToList())
                {

                    if (desc.Contains(prohibitedIngrd.Name)) return true;

                    foreach (var ingr in ingredientList)
                    {
                        if (ingr.Name.ToLower() == prohibitedIngrd.Name.ToLower()) return true;

                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Отримання інгредієнтів рецепту
        /// </summary>
        /// <param name="receptId">Іденитфікатор рецпту</param>
        /// <returns>Список інгредієнтів рецепту</returns>
        private List<Ingredient> GetIngredients(int receptId)
        {

            List<Ingredient> ingredientList = new List<Ingredient>();
            using(var context = new ReceptContext())
            {
                for (int i = 0; i < ingredientsData.Rows.Count; i++)
                {
                    string name;

                    if (ingredientsData.Rows[i].Cells["ingrName"].Value != null)
                        name = ingredientsData.Rows[i].Cells["ingrName"].Value.ToString();
                    else
                    {
                        MessageBox.Show("Вказано пустий інгредієнт, заповнійть його або видаліть");
                        return new List<Ingredient>();
                    }

                    if (!float.TryParse(ingredientsData.Rows[i].Cells["ingrCount"].Value.ToString(), out float count))
                    {
                        MessageBox.Show("Вказано невірну кількість");
                        return new List<Ingredient>();
                    }

                    Unit unit = new Unit();
                    if (ingredientsData.Rows[i].Cells["ingrUnit"].Value != null)
                    {
                        int.TryParse(ingredientsData.Rows[i].Cells["ingrUnit"].Value.ToString(), out int uId);
                        unit = context.Units.Where(u => u.id == uId).FirstOrDefault();
                    }
                    else
                    {
                        MessageBox.Show("Вкажіть одиницю виміру");
                        return new List<Ingredient>();
                    }

                    ingredientList.Add(new Ingredient() { Name = name, Count = count, ReceptId = receptId, UnitId = unit.id });
                }
            }

            return ingredientList;
        }


        //Редагування рецепту
        public void receptChange()
        {
            using (var context = new ReceptContext())
            {
                var recept = context.Recepts.Where(r => r.id == receptId).FirstOrDefault();

                if (recept != null)
                {
                    recept.Name = receptNameBox.Text;
                    recept.Description = receptDescBox.Text;
                    recept.ReceptTypeId = ((ReceptType)receptTypesBox.SelectedItem).id;
                    recept.Moderation = false;
                        
                    context.Ingredients.RemoveRange(recept.Ingredients);

                    var ingrds = GetIngredients(recept.id);

                    if (ingrds.Count != 0)
                    {
                        context.Ingredients.AddRange(ingrds);
                        context.SaveChanges();
                        MessageBox.Show("Рецепт відправленно на модерацію");

                        Close();
                    }
                }

            }
        }

        //Підтвердження створення рецепту
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (receptId != 0) receptChange();
            else receptCreate();

        }
    }
}

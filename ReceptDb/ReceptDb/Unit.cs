using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReceptDb
{
    public class Unit
    {
        public int id { get; set; }

        [MaxLength(10)]
        public string Name { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }

        public Unit()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}

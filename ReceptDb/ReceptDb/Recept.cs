using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReceptDb
{
    public class Recept
    {
        public int id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Moderation { get; set; }


        public virtual ICollection<Ingredient> Ingredients { get; set; }

        public int ReceptTypeId { get; set; }
        public virtual ReceptType ReceptType { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }



        public Recept()
        {
            Ingredients = new List<Ingredient>();
        }

    }
}

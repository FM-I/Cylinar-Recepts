using System.ComponentModel.DataAnnotations;

namespace ReceptDb
{
    public class Ingredient
    {
        public int id { get; set; }

        [MaxLength(35)]
        public string Name { get; set; }
        public float Count { get; set; }


        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }

        public int ReceptId { get; set; }
        public virtual Recept Recept { get; set; }

    }
}

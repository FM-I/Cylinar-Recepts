using System.ComponentModel.DataAnnotations;

namespace ReceptDb
{
    public class ProhibitedIngredient
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}

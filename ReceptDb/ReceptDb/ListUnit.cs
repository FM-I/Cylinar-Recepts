using System.ComponentModel.DataAnnotations;

namespace ReceptDb
{
    public class ListUnit
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; }
    }
}

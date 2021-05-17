using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReceptDb
{
    public class ReceptType
    {
        public int id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }


        public virtual ICollection<Recept> Recepts { get; set; }

        public ReceptType()
        {
            Recepts = new List<Recept>();
        }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReceptDb
{
    public class User
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string Login { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        public bool isAdmin { get; set; }

        public virtual ICollection<Recept> Recepts { get; set; }

        public User()
        {
            Recepts = new List<Recept>();
        }
    }
}

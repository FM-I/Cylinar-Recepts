using System;
using System.Data.Entity;

namespace ReceptDb
{
    public class ReceptContext : DbContext
    {

        public ReceptContext() : base("ReceptConect") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Recept> Recepts { get; set; }
        public DbSet<ReceptType> ReceptTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<ProhibitedIngredient> ProhibitedIngredients { get; set; }
    }
}

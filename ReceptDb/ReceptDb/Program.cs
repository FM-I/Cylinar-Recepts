using System;
using System.Collections.Generic;
using System.Linq;

namespace ReceptDb
{
    class Program
    {
        static void Main(string[] args)
        {


                #region
                //var users = new List<User>()
                //{
                //    new User()
                //    {
                //        Login = "User 1",
                //        Password = "qwer123"
                //    },
                //    new User()
                //    {
                //        Login = "User 2",
                //        Password = "123"
                //    }

                //};

                //context.Users.AddRange(users);
                //context.SaveChanges();

                //var receptTypes = new List<ReceptType>()
                //{
                //    new ReceptType(){Name = "Type 1"},
                //    new ReceptType(){Name = "Type 2"}
                //};

                //context.ReceptTypes.AddRange(receptTypes);
                //context.SaveChanges();

                //var recepts = new List<Recept>()
                //{
                //    new Recept()
                //    {
                //        Name = "Recept 1",
                //        Description = "Description...",
                //        ReceptTypeId = receptTypes[0].id,
                //        UserId = users[0].id
                //    },

                //    new Recept()
                //    {
                //        Name = "Recept 2",
                //        Description = "Description...",
                //        ReceptTypeId = receptTypes[1].id,
                //        UserId = users[1].id
                //    }
                //};

                //context.Recepts.AddRange(recepts);
                //context.SaveChanges();


                //var units = new List<Unit>()
                //{
                //    new Unit(){ Name = "unit 1"},
                //    new Unit(){ Name = "unit 2"},
                //    new Unit(){ Name = "unit 3"}
                //};

                //context.Units.AddRange(units);
                //context.SaveChanges();

                //var ingredients = new List<Ingredient>()
                //{
                //    new Ingredient() {
                //        Name = "Ingr 1",
                //        Count = 100,
                //        ReceptId = recepts[0].id,
                //        UnitId=units[0].id
                //    },
                //    new Ingredient() {
                //        Name = "Ingr 1",
                //        Count = 10,
                //        ReceptId = recepts[0].id,
                //        UnitId=units[1].id
                //    },
                //    new Ingredient() {
                //        Name = "Ingr 1",
                //        Count = 400,
                //        ReceptId = recepts[1].id,
                //        UnitId=units[2].id
                //    }
                //};

                //context.Ingredients.AddRange(ingredients);
                //context.SaveChanges();

                //var rec = context.Recepts.GroupBy(r => r.User.Login);


                //foreach (var user in rec)
                //{
                //    Console.WriteLine(user.Key);

                //    foreach (var recept in user)
                //    {
                //        Console.WriteLine("{0}\n{1}", recept.Name, recept.Description);

                //        foreach (var ingrds in recept.Ingredients.ToList())
                //        {
                //            Console.WriteLine("{0} - {1}", ingrds.Name, ingrds.Count, ingrds.Unit.Name);
                //        }

                //    }

                //}
                #endregion
        }
    }
}

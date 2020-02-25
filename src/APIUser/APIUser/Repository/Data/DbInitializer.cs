using APIUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIUser.Repository.Data
{
    public static class DbInitializer
    {
        public static void Initialize(APIUserContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            if (dbContext.Users.Any()) return;

            var users = new User[]
            {
                new User{Name = "Pedro", LastName = "Rodriguez", Address = "C/ 123", CreateDate = DateTime.Now, UpdateTime = DateTime.Now },
                new User{Name = "María", LastName = "Sanchez", Address = "C/ 456", CreateDate = DateTime.Now, UpdateTime = DateTime.Now },
                new User{Name = "Marta", LastName = "Hernandez", Address = "C/ 789", CreateDate = DateTime.Now, UpdateTime = DateTime.Now }
            };

            foreach(var user in users)
            {
                dbContext.Users.Add(user);
            }

            dbContext.SaveChanges();
        }
    }
}

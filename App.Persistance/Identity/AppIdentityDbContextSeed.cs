using App.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistance.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<User> userManager)
        {
            var defaultUser = new User { UserName = "admin@gmail.com", Email = "admin@gmail.com" };
            await userManager.CreateAsync(defaultUser, "Kamran123");
        }
    }
}

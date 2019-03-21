using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistance.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<AppUser> userManager)
        {
            var defaultUser = new AppUser { UserName = "admin@gmail.com", Email = "admin@gmail.com" };
            await userManager.CreateAsync(defaultUser, "Kamran123");
        }
    }
}

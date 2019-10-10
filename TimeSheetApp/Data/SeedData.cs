using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetApp.Models;

namespace TimeSheetApp.Data
{
    public class SeedData
    {
        public static async Task Initialize(ApplicationDbContext context, 
            UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is a admin role";
            string normName1 = role1.ToUpper();

            string role2 = "Manager";
            string desc2 = "This is the manager role";
            string normName2 = role2.ToUpper();

            string role3 = "Employee";
            string desc3 = "This is a basic employee role";
            string normName3 = role2.ToUpper();

            string role4 = "HR";
            string desc4 = "This is the HR role";
            string normName4 = role2.ToUpper();

            string password = "Develop@90";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new Role(role1, desc1, normName1));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new Role(role2, desc2, normName2));
            }
            if (await roleManager.FindByNameAsync(role3) == null)
            {
                await roleManager.CreateAsync(new Role(role3, desc3, normName3));
            }

            if (await userManager.FindByNameAsync("bill@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "bill@develop.com",
                    Email = "bill@develop.com",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
            }

            if (await userManager.FindByNameAsync("suzie@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "suzie@develop.com",
                    Email = "suzie@develop.com",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }

            if (await userManager.FindByNameAsync("bob@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "bob@develop.com",
                    Email = "bob@develop.com",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

            if (await userManager.FindByNameAsync("john@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "john@develop.com",
                    Email = "john@develop.com",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role3);
                }
            }
        }
    }
}

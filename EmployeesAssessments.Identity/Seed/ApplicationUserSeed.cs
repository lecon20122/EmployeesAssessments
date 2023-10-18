using EmployeesAssessments.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Identity.Seed
{
    public class ApplicationUserSeed
    {
        public static ApplicationUser Seed()
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            ApplicationUser user = new ApplicationUser
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "Admin",
                Email = "Admin@gmail.com",
                UserName = "Admin",
                NormalizedEmail = "ADMIN",
                NormalizedUserName = "ADMIN",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
            };

            user.PasswordHash = passwordHasher.HashPassword(user, "Admin@123");

            return user;
        }
    }
}

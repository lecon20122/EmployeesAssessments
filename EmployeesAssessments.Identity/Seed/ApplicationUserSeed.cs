using EmployeesAssessments.Identity.Models;

namespace EmployeesAssessments.Identity.Seed
{
    public class ApplicationUserSeed
    {
        public static ApplicationUser Seed()
        {
            ApplicationUser user = new ApplicationUser
            {
                Id = 1,
                UserName = "admin@gmail.com",
                FirstName = "Admin",
                LastName = "Admin",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA",
                ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58",
                PasswordHash = "AQAAAAIAAYagAAAAEHZtZrjReG6DkxuNGEkADcp3SpIKUcfwAvzQ7idbUFkPJA+5tbACXzr8YQVWQGAOlQ==" //admin@1234
            };
            return user;
        }
    }
}

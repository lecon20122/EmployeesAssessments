using EmployeesAssessments.Domain.Entities;

namespace EmployeesAssessments.Identity.Seed
{
    public class AssessmentSeeder
    {
        public static List<Assessment> Seed()
        {
            return new List<Assessment>()
            {
               new Assessment
               {
                    Id = 1,
                    Title = "Assessment 1",
                    Description = "Assessment 1 Description",
                    CreatedBy = 1,
                    CreatedAt = DateTime.Now,
                    Published = true,
               },
               new Assessment
               {
                      Id = 2,
                      Title = "Assessment 2",
                      Description = "Assessment 2 Description",
                      CreatedBy = 1,
                      CreatedAt = DateTime.Now,
                      Published = true,
                },
               new Assessment
               {
                      Id = 3,
                      Title = "Assessment 3",
                      Description = "Assessment 3 Description",
                      CreatedBy = 1,
                      CreatedAt = DateTime.Now,
                      Published = true,
                },
            };
        }
    }
}

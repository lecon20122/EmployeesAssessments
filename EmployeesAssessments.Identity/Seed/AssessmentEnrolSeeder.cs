using EmployeesAssessments.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Identity.Seed
{
    public class AssessmentEnrolSeeder
    {
        public static List<AssessmentEnrol> Seed()
        {
            return new List<AssessmentEnrol>()
            {
                new AssessmentEnrol
                {
                    Id = 1,
                    AssessmentId = 1,
                    UserId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new AssessmentEnrol
                {
                    Id = 2,
                    AssessmentId = 2,
                    UserId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new AssessmentEnrol
                {
                    Id = 3,
                    AssessmentId = 3,
                    UserId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
            };
        }
    }
}

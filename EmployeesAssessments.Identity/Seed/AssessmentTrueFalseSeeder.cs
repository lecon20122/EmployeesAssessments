using EmployeesAssessments.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Identity.Seed
{
    public class AssessmentTrueFalseSeeder
    {
        public static List<AssessmentTrueFalse> Seed()
        {
            return new List<AssessmentTrueFalse>()
            {
                new AssessmentTrueFalse()
                {
                    Id = 1,
                    AssessmentId = 1,
                    IsTrue = true,
                    QuestionId = 1,
                    CreatedAt = DateTime.Now,
                },
                new AssessmentTrueFalse()
                {
                    Id = 2,
                    AssessmentId = 1,
                    QuestionId = 2,
                    IsTrue = true,
                    CreatedAt = DateTime.Now,
                },
            };
        }
    }
}

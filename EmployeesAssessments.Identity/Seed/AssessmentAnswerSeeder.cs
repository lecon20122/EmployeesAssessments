using EmployeesAssessments.Domain.Entities;

namespace EmployeesAssessments.Identity.Seed
{
    public class AssessmentAnswerSeeder
    {
        public static List<AssessmentAnswer> Seed()
        {
            return new List<AssessmentAnswer>()
            {
                new AssessmentAnswer()
                {
                    Id = 1,
                    AssessmentId = 1,
                    AssessmentQuestionId = 1,
                    UserId = 1,
                    CreatedAt = DateTime.Now,
                    Answer = "Yes",
                    Score = 1
                },
                new AssessmentAnswer()
                {
                    Id = 2,
                    AssessmentId = 1,
                    AssessmentQuestionId = 2,
                    UserId = 1,
                    CreatedAt = DateTime.Now,
                    Answer = "Yes",
                    Score = 1,
                },
            };
        }
    }
}

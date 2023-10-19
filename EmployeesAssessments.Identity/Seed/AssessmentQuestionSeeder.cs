using EmployeesAssessments.Domain.Entities;

namespace EmployeesAssessments.Identity.Seed
{
    public class AssessmentQuestionSeeder
    {
        //types of questios is Multiple-select   
        //Multiple-choice   
        //Match   
        //Fill in blanks   
        //Long answer   
        //Short answer   
        //True or False   
        public static List<AssessmentQuestion> Seed()
        {
            return new List<AssessmentQuestion>()
            {
                new AssessmentQuestion()
                {
                    Id = 1,
                    Question = "Do you have a good communication skills?",
                    CreatedAt = DateTime.Now,
                    Order = 1,
                    Level = 1,
                    Type = "true_false"
                },
                new AssessmentQuestion()
                {
                    Id = 2,
                    Question= "Do you have a good communication skills?",
                    CreatedAt = DateTime.Now,
                    Order = 2,
                    Level = 1,
                    Type = "true_false"
                },
                new AssessmentQuestion()
                {
                    Id = 3,
                    Question= "Do you have a good .NET skills?",
                    CreatedAt = DateTime.Now,
                    Order = 3,
                    Level = 1,
                    Type = "true_false"
                },
                new AssessmentQuestion()
                {
                    Id = 4,
                    Question= "Do you have a good React skills?",
                    CreatedAt = DateTime.Now,
                    Order = 4,
                    Level = 1,
                    Type = "true_false"
                },
            };
        }
    }
}

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
                new AssessmentQuestion()
                {
                    Id = 5,
                    Question= "Do you have a good Angular skills?",
                    CreatedAt = DateTime.Now,
                    Order = 5,
                    Level = 1,
                    Type = "true_false"
                },
                new AssessmentQuestion()
                {
                    Id = 6,
                    Question= "Do you have a good communication skills?",
                    CreatedAt = DateTime.Now,
                    Order = 6,
                    Level = 1,
                    Type = "true_false"
                },
                new AssessmentQuestion()
                {
                    Id = 7,
                    Question= "Do you have a good communication skills?",
                    CreatedAt = DateTime.Now,
                    Order = 7,
                    Level = 1,
                    Type = "true_false"
                },
                new AssessmentQuestion()
                {
                    Id = 8,
                    Question= "Do you have a good communication skills?",
                    CreatedAt = DateTime.Now,
                    Order = 8,
                    Level = 1,
                    Type = "true_false"
                },
                new AssessmentQuestion()
                {
                    Id = 9,
                    Question= "Do you have a good communication skills?",
                    CreatedAt = DateTime.Now,
                    Order = 9,
                    Level = 1,
                    Type = "true_false"
                },
            };
        }
    }
}

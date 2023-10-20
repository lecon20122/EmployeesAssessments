namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithQuestion
{
    public class AssessmentQuestionDto
    {
        public string Question { get; set; }
        public long CategoryId { get; set; }
        public int Level { get; set; }
        public int Order { get; set; }
        public string Type { get; set; }
    }
}

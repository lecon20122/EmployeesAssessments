namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithAssessmentQuestion
{
    public class AssessmentAnswersWithAssessmentQuestionVm
    {
        public long Id { get; set; }
        public string Answer { get; set; }
        public long AssessmentId { get; set; }
        public long QuestionId { get; set; }
        public AssessmentQuestionDto AssessmentQuestion { get; set; }
        public long UserId { get; set; }
        public byte Score { get; set; }
    }
}

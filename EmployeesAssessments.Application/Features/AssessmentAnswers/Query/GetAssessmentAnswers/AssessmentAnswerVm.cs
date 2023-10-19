using EmployeesAssessments.Domain.Entities;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswers
{
    public class AssessmentAnswerVm
    {
        public long Id { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public long QuestionId { get; set; }
        public AssessmentQuestion Question { get; set; }
        public string Answer { get; set; }
        public long UserId { get; set; }
        public byte Score { get; set; }
    }
}

using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentAnswer : BaseEntity
    {
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public long AssessmentQuestionId { get; set; }
        public AssessmentQuestion AssessmentQuestion { get; set; }
        public string Answer { get; set; }
        public long UserId { get; set; }
        public byte Score { get; set; }
    }
}

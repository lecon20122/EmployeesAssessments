using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentText : BaseEntity
    {
        public string Answer { get; set; }
        public long AssessmentQuestionId { get; set; }
        public AssessmentQuestion Question { get; set; }
        public int Order { get; set; }
    }
}

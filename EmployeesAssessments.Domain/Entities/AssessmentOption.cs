using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentOption : BaseEntity
    {
        public string Option { get; set; }
        public long AssessmentQuestionId { get; set; }
        public AssessmentQuestion Question { get; set; }
        public byte Correct { get; set; }
        public int Order { get; set; }
    }
}

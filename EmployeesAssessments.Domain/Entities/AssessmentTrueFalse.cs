using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentTrueFalse : BaseEntity
    {
        public long AssessmentQuestionId { get; set; }
        public long AssessmentId { get; set; }
        public bool IsTrue { get; set; }
    }
}

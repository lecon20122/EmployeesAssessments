using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentTrueFalse : BaseEntity
    {
        public long QuestionId { get; set; }
        public long AssessmentId { get; set; }
        public int IsTrue { get; set; }
    }
}

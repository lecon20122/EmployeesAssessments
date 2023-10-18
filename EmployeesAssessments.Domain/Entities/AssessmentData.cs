using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentData : BaseEntity
    {
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public string Data { get; set; }
    }
}

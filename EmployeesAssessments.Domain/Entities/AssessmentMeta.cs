using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentMeta : BaseEntity
    {
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}

using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentDepartment : BaseEntity
    {
        public long? GroupId { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
    }
}

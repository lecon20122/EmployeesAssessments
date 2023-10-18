using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentSection : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public int Order { get; set; }
    }
}

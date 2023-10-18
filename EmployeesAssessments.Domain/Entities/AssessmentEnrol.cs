using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentEnrol : BaseEntity
    {
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public long UserId { get; set; }
        public int Result { get; set; }
        public byte Score { get; set; }
    }
}

using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentQuestion : BaseEntity
    {
        public string Question { get; set; }
        public long CategoryId { get; set; }
        public int Level { get; set; }
        public int Order { get; set; }
        public string Type { get; set; }
        public ICollection<Assessment> Assessments { get; set; }
        public ICollection<AssessmentAnswer> Answers { get; set; }
    }
}

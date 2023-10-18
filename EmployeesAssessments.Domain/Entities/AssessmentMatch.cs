using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentMatch : BaseEntity
    {
        public string AnswerIdKey { get; set; }
        public string QuestionIdKey { get; set; }
        public string Option { get; set; }
        public string Answer { get; set; }
        public long QuestionId { get; set; }
        public AssessmentQuestion Question { get; set; }
        public int Order { get; set; }
    }
}

using EmployeesAssessments.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query
{
    public class AssessmentAnswerVm
    {
        public long Id { get; set; }
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public long QuestionId { get; set; }
        public AssessmentQuestion Question { get; set; }
        public string Answer { get; set; }
        public long UserId { get; set; }
        public byte Score { get; set; }
    }
}

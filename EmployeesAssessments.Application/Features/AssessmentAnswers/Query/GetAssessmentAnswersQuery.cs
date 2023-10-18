using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query
{
    public class GetAssessmentAnswersQuery : IRequest<List<AssessmentAnswerVm>>
    {
        public long? AssessmentId { get; set; }
    }
}

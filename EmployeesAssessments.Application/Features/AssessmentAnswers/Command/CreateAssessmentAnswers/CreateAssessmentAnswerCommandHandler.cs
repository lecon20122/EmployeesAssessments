using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers
{
    public class CreateAssessmentAnswerCommandHandler : IRequestHandler<CreateAssessmentAnswerCommand, AssessmentAnswerVm>
    {
        public Task<AssessmentAnswerVm> Handle(CreateAssessmentAnswerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

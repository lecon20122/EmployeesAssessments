using MediatR;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers
{
    public class CreateAssessmentAnswerCommand : IRequest<bool>
    {
        public List<AssessmentAnswerRequest> assessmentAnswer { get; set; }
    }
}

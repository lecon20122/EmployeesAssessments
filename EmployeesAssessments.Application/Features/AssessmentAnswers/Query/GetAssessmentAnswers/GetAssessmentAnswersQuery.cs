using MediatR;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswers
{
    public class GetAssessmentAnswersQuery : IRequest<List<AssessmentAnswerVm>>
    {
    }
}

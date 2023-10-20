using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithQuestion;
using MediatR;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithQuestion
{
    public class GetAssessmentAnswersWithQuestionQuery : IRequest<List<AssessmentAnswersWithQuestionVm>>
    {
    }
}

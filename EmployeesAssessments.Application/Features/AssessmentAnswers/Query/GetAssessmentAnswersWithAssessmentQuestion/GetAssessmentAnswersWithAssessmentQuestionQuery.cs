using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithAssessmentQuestion;
using MediatR;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithAssessmentAndQuestion
{
    public class GetAssessmentAnswersWithAssessmentQuestionQuery : IRequest<List<AssessmentAnswersWithAssessmentQuestionVm>>
    {
    }
}

using EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers;
using EmployeesAssessments.Domain.Entities;

namespace EmployeesAssessments.Application.Contracts.Persistence
{
    public interface IAssessmentAsnwerRepository
    {
        Task<List<AssessmentAnswer>> GetAssessmentAnswers();
        Task<List<AssessmentAnswer>> GetAssessmentAnswersWithQuestion();
        Task<bool> CreateAsync(CreateAssessmentAnswerCommand command);
    }
}

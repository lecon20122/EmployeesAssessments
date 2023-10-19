using EmployeesAssessments.Domain.Entities;

namespace EmployeesAssessments.Application.Contracts.Persistence
{
    public interface IAssessmentAsnwerRepository
    {
        Task<List<AssessmentAnswer>> GetAssessmentAnswers();
        Task<List<AssessmentAnswer>> GetAssessmentAnswersWithAssessmentQuestion();
    }
}

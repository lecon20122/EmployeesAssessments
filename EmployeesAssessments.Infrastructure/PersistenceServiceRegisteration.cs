using EmployeesAssessments.Application.Contracts.Persistence;
using EmployeesAssessments.Persisitence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeesAssessments.Persisitence
{
    public static class PersistenceServiceRegisteration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IAssessmentAsnwerRepository, AssessmentAnswerRepository>();
        }
    }
}

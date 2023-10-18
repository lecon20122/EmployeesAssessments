using EmployeesAssessments.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Application.Contracts.Persistence
{
    public interface IAssessmentAsnwerRepository
    {
        Task<List<AssessmentAnswer>> GetAssessmentAnswers(long? assessmentId);
    }
}

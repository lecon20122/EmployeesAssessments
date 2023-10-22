using EmployeesAssessments.Application.Contracts.Persistence;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers;
using EmployeesAssessments.Domain.Entities;
using EmployeesAssessments.Identity;
using EmployeesAssessments.Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EmployeesAssessments.Persisitence.Repository
{
    public class AssessmentAnswerRepository : IAssessmentAsnwerRepository
    {
        private readonly ApplicationIdentityDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private long _userId;

        public AssessmentAnswerRepository(ApplicationIdentityDbContext dbContext,
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor
            )
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _userId = long.Parse(_userManager.GetUserId(principal: _httpContextAccessor.HttpContext.User));
        }

        public Task<bool> CreateAsync(CreateAssessmentAnswerCommand command)
        {
            foreach (var item in command.assessmentAnswer)
            {

            }
            return Task.FromResult(true);
        }

        public async Task<List<AssessmentAnswer>> GetAssessmentAnswers()
        {
            return await _dbContext.AssessmentAnswers
                    .Where(x => x.UserId == _userId)
                    .ToListAsync();

        }

        public async Task<List<AssessmentAnswer>> GetAssessmentAnswersWithQuestion()
        {
            return await _dbContext.AssessmentAnswers
                    .Include(x => x.AssessmentQuestion)
                    .Where(x => x.UserId == _userId)
                    .ToListAsync();
        }
    }
}

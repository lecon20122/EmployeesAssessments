using EmployeesAssessments.Application.Contracts.Persistence;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers;
using EmployeesAssessments.Application.Models.AssessmentAnswerTypes;
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

        public async Task<bool> CreateAsync(CreateAssessmentAnswerCommand command)
        {
            foreach (var answer in command.assessmentAnswers)
            {
                ////////////////////**Disclaimer**/////////////////////////
                ///////////////////////////////////////////////////////////
                //for Fill, Match, Multiple Select types
                //i don't know what el {question,answer} means
                //also for the Multiple Select type i don't know what the List of int means or where i should save them.
                //determine the type of the answer and create the answer
                ///////////////////////////////////////////////////////////
                ////////////////////**Disclaimer**/////////////////////////


                if (answer is TrueFalseAnswerType)
                {
                    var trueFalseAnswer = new AssessmentAnswer
                    {
                        AssessmentId = command.assessmentId,
                        AssessmentQuestionId = answer.QuestionId,
                        Answer = ((TrueFalseAnswerType)answer).Answer.ToString(),
                        UserId = _userId
                    };
                    await _dbContext.AssessmentAnswers.AddAsync(trueFalseAnswer);
                }
                else if (answer is MultipleChoiceAnswerType)
                {
                    var multipleChoiceAnswer = new AssessmentAnswer
                    {
                        // assessmentId its not found in the post_assessment_answers.json file
                        // so i assumed all these answers for the same assessment
                        AssessmentId = command.assessmentId,
                        AssessmentQuestionId = answer.QuestionId,
                        UserId = _userId,
                        Answer = ((MultipleChoiceAnswerType)answer).Answer.ToString()
                    };
                    await _dbContext.AssessmentAnswers.AddAsync(multipleChoiceAnswer);
                }
                else if (answer is LongAnswerType)
                {
                    var textAnswer = new AssessmentAnswer
                    {
                        AssessmentId = command.assessmentId,
                        Answer = ((LongAnswerType)answer).Answer,
                        AssessmentQuestionId = answer.QuestionId,
                        UserId = _userId
                    };
                    await _dbContext.AssessmentAnswers.AddAsync(textAnswer);
                }
                else if (answer is ShortAnswerType)
                {
                    var textAnswer = new AssessmentAnswer
                    {
                        AssessmentId = command.assessmentId,
                        Answer = ((ShortAnswerType)answer).Answer,
                        AssessmentQuestionId = answer.QuestionId,
                        UserId = _userId
                    };
                    await _dbContext.AssessmentAnswers.AddAsync(textAnswer);
                }

            }

            await _dbContext.SaveChangesAsync();

            return true;
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

using EmployeesAssessments.Application.Contracts.Persistence;
using MediatR;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers
{
    public class CreateAssessmentAnswerCommandHandler : IRequestHandler<CreateAssessmentAnswerCommand, bool>
    {
        private readonly IAssessmentAsnwerRepository _assessmentAsnwerRepository;

        public CreateAssessmentAnswerCommandHandler(IAssessmentAsnwerRepository assessmentAsnwerRepository)
        {
            _assessmentAsnwerRepository = assessmentAsnwerRepository;
        }
        public async Task<bool> Handle(CreateAssessmentAnswerCommand request, CancellationToken cancellationToken)
        {
            var result = await _assessmentAsnwerRepository.CreateAsync(request);
            return result;
        }
    }
}

using AutoMapper;
using EmployeesAssessments.Application.Contracts.Persistence;
using EmployeesAssessments.Application.Exceptions;
using MediatR;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithQuestion
{
    public class GetAssessmentAnswersWithQuestionQueryHandler : IRequestHandler<GetAssessmentAnswersWithQuestionQuery, List<AssessmentAnswersWithQuestionVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAssessmentAsnwerRepository _assessmentAsnwerRepository;

        public GetAssessmentAnswersWithQuestionQueryHandler(IMapper mapper, IAssessmentAsnwerRepository assessmentAsnwerRepository)
        {
            _mapper = mapper;
            _assessmentAsnwerRepository = assessmentAsnwerRepository;
        }

        public async Task<List<AssessmentAnswersWithQuestionVm>> Handle(GetAssessmentAnswersWithQuestionQuery request, CancellationToken cancellationToken)
        {
            var assessmentAnswers = await _assessmentAsnwerRepository.GetAssessmentAnswersWithQuestion();

            if (assessmentAnswers == null) throw new NotFoundException();

            return _mapper.Map<List<AssessmentAnswersWithQuestionVm>>(assessmentAnswers);
        }
    }
}

using AutoMapper;
using EmployeesAssessments.Application.Contracts.Persistence;
using EmployeesAssessments.Application.Exceptions;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithAssessmentQuestion;
using MediatR;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithAssessmentAndQuestion
{
    public class GetAssessmentAnswersWithAssessmentQuestionQueryHandler : IRequestHandler<GetAssessmentAnswersWithAssessmentQuestionQuery, List<AssessmentAnswersWithAssessmentQuestionVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAssessmentAsnwerRepository _assessmentAsnwerRepository;

        public GetAssessmentAnswersWithAssessmentQuestionQueryHandler(IMapper mapper, IAssessmentAsnwerRepository assessmentAsnwerRepository)
        {
            _mapper = mapper;
            _assessmentAsnwerRepository = assessmentAsnwerRepository;
        }

        public async Task<List<AssessmentAnswersWithAssessmentQuestionVm>> Handle(GetAssessmentAnswersWithAssessmentQuestionQuery request, CancellationToken cancellationToken)
        {
            var assessmentAnswers = await _assessmentAsnwerRepository.GetAssessmentAnswersWithAssessmentQuestion();

            if (assessmentAnswers == null) throw new NotFoundException();

            return _mapper.Map<List<AssessmentAnswersWithAssessmentQuestionVm>>(assessmentAnswers);
        }
    }
}

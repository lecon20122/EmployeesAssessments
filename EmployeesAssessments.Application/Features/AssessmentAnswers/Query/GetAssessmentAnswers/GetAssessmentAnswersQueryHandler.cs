using AutoMapper;
using EmployeesAssessments.Application.Contracts.Persistence;
using EmployeesAssessments.Application.Exceptions;
using MediatR;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswers
{
    public class GetAssessmentAnswersWithAssessmentAndQuestionQueryHandler : IRequestHandler<GetAssessmentAnswersQuery, List<AssessmentAnswerVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAssessmentAsnwerRepository _assessmentAsnwerRepository;

        public GetAssessmentAnswersWithAssessmentAndQuestionQueryHandler(IMapper mapper, IAssessmentAsnwerRepository assessmentAsnwerRepository)
        {
            _mapper = mapper;
            _assessmentAsnwerRepository = assessmentAsnwerRepository;
        }

        public async Task<List<AssessmentAnswerVm>> Handle(GetAssessmentAnswersQuery request, CancellationToken cancellationToken)
        {
            var assessmentAnswers = await _assessmentAsnwerRepository.GetAssessmentAnswers();

            if (assessmentAnswers == null) throw new NotFoundException();

            return _mapper.Map<List<AssessmentAnswerVm>>(assessmentAnswers);
        }
    }
}

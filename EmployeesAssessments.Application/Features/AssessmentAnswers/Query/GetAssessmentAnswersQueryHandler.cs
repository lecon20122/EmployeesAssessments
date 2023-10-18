using AutoMapper;
using EmployeesAssessments.Application.Contracts.Persistence;
using EmployeesAssessments.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Query
{
    public class GetAssessmentAnswersQueryHandler : IRequestHandler<GetAssessmentAnswersQuery, List<AssessmentAnswerVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAssessmentAsnwerRepository _assessmentAsnwerRepository;

        public GetAssessmentAnswersQueryHandler(IMapper mapper, IAssessmentAsnwerRepository assessmentAsnwerRepository)
        {
            _mapper = mapper;
            _assessmentAsnwerRepository = assessmentAsnwerRepository;
        }

        public async Task<List<AssessmentAnswerVm>> Handle(GetAssessmentAnswersQuery request, CancellationToken cancellationToken)
        {
            var assessmentAnswers = await _assessmentAsnwerRepository.GetAssessmentAnswers(request.AssessmentId);

            if (assessmentAnswers == null) throw new NotFoundException();

            return _mapper.Map<List<AssessmentAnswerVm>>(assessmentAnswers);
        }
    }
}

using AutoMapper;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswers;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithAssessmentQuestion;
using EmployeesAssessments.Domain.Entities;

namespace EmployeesAssessments.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AssessmentAnswer, AssessmentAnswerVm>().ReverseMap();

            CreateMap<AssessmentAnswer, AssessmentAnswersWithAssessmentQuestionVm>().ReverseMap();

            CreateMap<AssessmentQuestion, AssessmentQuestionDto>().ReverseMap();
        }
    }
}

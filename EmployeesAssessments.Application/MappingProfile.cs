using AutoMapper;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswers;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswersWithQuestion;
using EmployeesAssessments.Domain.Entities;

namespace EmployeesAssessments.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AssessmentAnswer, GetAssessmentAnswerVm>().ReverseMap();

            CreateMap<AssessmentAnswer, AssessmentAnswersWithQuestionVm>().ReverseMap();

            CreateMap<AssessmentQuestion, AssessmentQuestionDto>().ReverseMap();
        }
    }
}

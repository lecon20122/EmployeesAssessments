using AutoMapper;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Query.GetAssessmentAnswers;
using EmployeesAssessments.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AssessmentAnswer, AssessmentAnswerVm>().ReverseMap();
        }
    }
}

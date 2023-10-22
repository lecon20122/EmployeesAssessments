using EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmployeesAssessments.Application.Models.AssessmentAnswerTypes
{
    public class FillAnswerType : AssessmentAnswerRequest
    {
        [JsonPropertyName("answer")]
        public List<FillAnswer> Answer { get; set; }
    }
}

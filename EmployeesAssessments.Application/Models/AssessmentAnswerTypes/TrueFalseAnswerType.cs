using EmployeesAssessments.Application.Extensions;
using EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers;
using System.Text.Json.Serialization;

namespace EmployeesAssessments.Application.Models.AssessmentAnswerTypes
{
    public class TrueFalseAnswerType : AssessmentAnswerRequest
    {
        [JsonPropertyName("answer")]
        [JsonConverter(typeof(JsonBoolenConverter))]
        public bool Answer { get; set; }
    }
}

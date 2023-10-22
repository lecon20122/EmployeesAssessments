using EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers;
using System.Text.Json.Serialization;

namespace EmployeesAssessments.Application.Models.AssessmentAnswerTypes
{
    public class ShortAnswerType : AssessmentAnswerRequest
    {
        [JsonPropertyName("answer")]
        public string Answer { get; set; }
    }
}

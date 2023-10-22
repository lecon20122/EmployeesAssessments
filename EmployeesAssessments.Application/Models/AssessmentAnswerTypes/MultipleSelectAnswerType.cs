using EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers;
using System.Text.Json.Serialization;

namespace EmployeesAssessments.Application.Models.AssessmentAnswerTypes
{
    public class MultipleSelectAnswerType : AssessmentAnswerRequest
    {
        [JsonPropertyName("answer")]
        public List<int> Answer { get; set; }
    }
}

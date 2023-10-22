using EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers;
using System.Text.Json.Serialization;

namespace EmployeesAssessments.Application.Models.AssessmentAnswerTypes
{
    public class MatchAnswerType : AssessmentAnswerRequest
    {
        [JsonPropertyName("answer")]
        public List<MatchAnswer> Answer { get; set; }
    }
}

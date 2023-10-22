using MediatR;
using System.Text.Json.Serialization;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers
{
    public class CreateAssessmentAnswerCommand : IRequest<bool>
    {
        [JsonPropertyName("assessmentId")]
        public int assessmentId { get; set; }

        [JsonPropertyName("assessmentAnswer")]
        public List<AssessmentAnswerRequest> assessmentAnswers { get; set; }
    }
}

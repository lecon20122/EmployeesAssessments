using EmployeesAssessments.Application.Models.AssessmentAnswerTypes;
using System.Text.Json.Serialization;

namespace EmployeesAssessments.Application.Features.AssessmentAnswers.Command.CreateAssessmentAnswers
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(FillAnswerType), "fill")]
    [JsonDerivedType(typeof(MultipleChoiceAnswerType), "mc")]
    [JsonDerivedType(typeof(MultipleSelectAnswerType), "ms")]
    [JsonDerivedType(typeof(MatchAnswerType), "match")]
    [JsonDerivedType(typeof(LongAnswerType), "long")]
    [JsonDerivedType(typeof(ShortAnswerType), "short")]
    [JsonDerivedType(typeof(TrueFalseAnswerType), "true_false")]
    public class AssessmentAnswerRequest
    {
        [JsonPropertyName("type")]
        [JsonPropertyOrder(1)]
        public string? Type { get; set; }

        [JsonPropertyName("question")]
        public long QuestionId { get; set; }

    }
}

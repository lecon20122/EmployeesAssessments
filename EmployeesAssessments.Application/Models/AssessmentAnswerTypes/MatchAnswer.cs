﻿using System.Text.Json.Serialization;

namespace EmployeesAssessments.Application.Models.AssessmentAnswerTypes
{
    public class MatchAnswer
    {
        [JsonPropertyName("question")]
        public string Question { get; set; }
        [JsonPropertyName("answer")]
        public string Answer { get; set; }
    }
}
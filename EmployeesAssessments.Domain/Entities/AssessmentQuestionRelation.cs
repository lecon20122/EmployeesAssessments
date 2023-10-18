﻿using EmployeesAssessments.Domain.Common;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentQuestionRelation : BaseEntity
    {
        public long QuestionId { get; set; }
        public long AssessmentId { get; set; }
    }
}

﻿using EmployeesAssessments.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Domain.Entities
{
    public class AssessmentAnswer : BaseEntity
    {
        public long AssessmentId { get; set; }
        public Assessment Assessment { get; set; }
        public long QuestionId { get; set; }
        public AssessmentQuestion Question { get; set; }
        public string Answer { get; set; }
        public long UserId { get; set; }
        public byte Score { get; set; }
    }
}

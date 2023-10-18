using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Identity.Models
{
    public class ApplicationUser : IdentityUser<long>
    {
        public Guid ApiKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsBanned { get; set; }
        public bool? IsVerified { get; set; }
        public Guid? ConfirmCode { get; set; }
        public string? DisplayName { get; set; }
        public string? UserUrl { get; set; }
        public bool? IsLdap { get; set; }
        public string? RememberToken { get; set; }
        public string? Otp { get; set; }
        public long? ProfilePictureId { get; set; }
        public DateTime? OtpCreatedAt { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public DateTime? PasswordChangedAt { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}

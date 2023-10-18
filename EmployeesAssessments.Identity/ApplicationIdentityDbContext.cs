using EmployeesAssessments.Domain.Entities;
using EmployeesAssessments.Identity.Models;
using EmployeesAssessments.Identity.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAssessments.Identity
{
    public class ApplicationIdentityDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : base(options)
        {

        }

        // add the dbsets here of the core entities

        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentAnswer> AssessmentAnswers { get; set; }
        public DbSet<AssessmentData> AssessmentData { get; set; }
        public DbSet<AssessmentDepartment> AssessmentDepartments { get; set; }
        public DbSet<AssessmentEnrol> AssessmentEnrols { get; set; }
        public DbSet<AssessmentMatch> AssessmentMatchs { get; set; }
        public DbSet<AssessmentMeta> AssessmentMeta { get; set; }
        public DbSet<AssessmentOption> AssessmentOptions { get; set; }
        public DbSet<AssessmentQuestion> AssessmentQuestions { get; set; }
        public DbSet<AssessmentSection> AssessmentSections { get; set; }
        public DbSet<AssessmentText> AssessmentTexts { get; set; }
        public DbSet<AssessmentTrueFalse> AssessmentTrueFalse { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().HasData(ApplicationUserSeed.Seed());
        }
    }
}

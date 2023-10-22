using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeesAssessments.Identity.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedForAssessmentQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.InsertData(
                table: "AssessmentQuestions",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Level", "Order", "Question", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 5L, 0L, new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(563), 1, 5, "Do you have a good Angular skills?", "true_false", null },
                    { 6L, 0L, new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(573), 1, 6, "Do you have a good communication skills?", "true_false", null },
                    { 7L, 0L, new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(579), 1, 7, "Do you have a good communication skills?", "true_false", null },
                    { 8L, 0L, new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(585), 1, 8, "Do you have a good communication skills?", "true_false", null },
                    { 9L, 0L, new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(590), 1, 9, "Do you have a good communication skills?", "true_false", null }
                });

            migrationBuilder.UpdateData(
                table: "AssessmentTrueFalse",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "AssessmentTrueFalse",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 15, 32, 30, 160, DateTimeKind.Local).AddTicks(486));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "AssessmentQuestions",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "AssessmentTrueFalse",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "AssessmentTrueFalse",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Assessments",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 19, 20, 1, 55, 512, DateTimeKind.Local).AddTicks(6982));
        }
    }
}

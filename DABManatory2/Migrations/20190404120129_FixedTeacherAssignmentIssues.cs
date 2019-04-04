using Microsoft.EntityFrameworkCore.Migrations;

namespace DABMandatory2.Migrations
{
    public partial class FixedTeacherAssignmentIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Assignments_Teacher_ID",
                table: "Assignments");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_Teacher_ID",
                table: "Assignments",
                column: "Teacher_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Assignments_Teacher_ID",
                table: "Assignments");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_Teacher_ID",
                table: "Assignments",
                column: "Teacher_ID",
                unique: true,
                filter: "[Teacher_ID] IS NOT NULL");
        }
    }
}

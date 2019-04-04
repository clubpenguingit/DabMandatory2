using Microsoft.EntityFrameworkCore.Migrations;

namespace DABMandatory2.Migrations
{
    public partial class OverhaulVersion26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "IsEnrolledTos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "IsEnrolledTos");
        }
    }
}

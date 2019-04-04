using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DABMandatory2.Migrations
{
    public partial class OverhaulVesion25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Course_ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    AU_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    GraduationDate = table.Column<DateTime>(nullable: false),
                    EnrollmentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.AU_ID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Teacher_ID = table.Column<string>(maxLength: 10, nullable: false),
                    AssistantOrResponsible = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Teacher_ID);
                });

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Calendar_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => new { x.Calendar_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_Calendars_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseContents",
                columns: table => new
                {
                    Content_ID = table.Column<string>(maxLength: 50, nullable: false),
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseContents", x => new { x.Content_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_CourseContents_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsEnrolledTos",
                columns: table => new
                {
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false),
                    AU_ID = table.Column<string>(maxLength: 10, nullable: false),
                    ActiveOrPassed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsEnrolledTos", x => new { x.AU_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_IsEnrolledTos_Students_AU_ID",
                        column: x => x.AU_ID,
                        principalTable: "Students",
                        principalColumn: "AU_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsEnrolledTos_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Assignment_ID = table.Column<string>(maxLength: 255, nullable: false),
                    AU_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Passed = table.Column<bool>(nullable: false),
                    Course_ID = table.Column<string>(maxLength: 100, nullable: true),
                    Teacher_ID = table.Column<string>(maxLength: 10, nullable: true),
                    TIMESTAMP = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => new { x.AU_ID, x.Assignment_ID });
                    table.ForeignKey(
                        name: "FK_Assignments_Students_AU_ID",
                        column: x => x.AU_ID,
                        principalTable: "Students",
                        principalColumn: "AU_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_Teachers_Teacher_ID",
                        column: x => x.Teacher_ID,
                        principalTable: "Teachers",
                        principalColumn: "Teacher_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseResponsibles",
                columns: table => new
                {
                    AU_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Teacher_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Assistant_Or_Responsible = table.Column<string>(maxLength: 15, nullable: true, defaultValue: "Responsible")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseResponsibles", x => new { x.AU_ID, x.Teacher_ID });
                    table.ForeignKey(
                        name: "FK_CourseResponsibles_Teachers_Teacher_ID",
                        column: x => x.Teacher_ID,
                        principalTable: "Teachers",
                        principalColumn: "Teacher_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsAssignedTos",
                columns: table => new
                {
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false),
                    Teacher_ID = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsAssignedTos", x => new { x.Teacher_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_IsAssignedTos_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsAssignedTos_Teachers_Teacher_ID",
                        column: x => x.Teacher_ID,
                        principalTable: "Teachers",
                        principalColumn: "Teacher_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeachingAssistants",
                columns: table => new
                {
                    AU_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Teacher_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Assistant_Or_Responsible = table.Column<string>(maxLength: 15, nullable: true, defaultValue: "Assistant")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachingAssistants", x => new { x.AU_ID, x.Teacher_ID });
                    table.ForeignKey(
                        name: "FK_TeachingAssistants_Teachers_Teacher_ID",
                        column: x => x.Teacher_ID,
                        principalTable: "Teachers",
                        principalColumn: "Teacher_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deadlines",
                columns: table => new
                {
                    Calendar_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false),
                    DeadlineDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deadlines", x => new { x.DeadlineDate, x.Calendar_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_Deadlines_Calendars_Calendar_ID_Course_ID",
                        columns: x => new { x.Calendar_ID, x.Course_ID },
                        principalTable: "Calendars",
                        principalColumns: new[] { "Calendar_ID", "Course_ID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HandIns",
                columns: table => new
                {
                    Calendar_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false),
                    HandinDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandIns", x => new { x.HandinDate, x.Calendar_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_HandIns_Calendars_Calendar_ID_Course_ID",
                        columns: x => new { x.Calendar_ID, x.Course_ID },
                        principalTable: "Calendars",
                        principalColumns: new[] { "Calendar_ID", "Course_ID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LectureDates",
                columns: table => new
                {
                    Calendar_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false),
                    Lecture = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureDates", x => new { x.Lecture, x.Calendar_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_LectureDates_Calendars_Calendar_ID_Course_ID",
                        columns: x => new { x.Calendar_ID, x.Course_ID },
                        principalTable: "Calendars",
                        principalColumns: new[] { "Calendar_ID", "Course_ID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Folders",
                columns: table => new
                {
                    Folder_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false),
                    Content_ID = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folders", x => new { x.Folder_ID, x.Content_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_Folders_CourseContents_Content_ID_Course_ID",
                        columns: x => new { x.Content_ID, x.Course_ID },
                        principalTable: "CourseContents",
                        principalColumns: new[] { "Content_ID", "Course_ID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentAreas",
                columns: table => new
                {
                    ContentArea_ID = table.Column<string>(maxLength: 50, nullable: false),
                    Content_ID = table.Column<string>(maxLength: 50, nullable: false),
                    Course_ID = table.Column<string>(maxLength: 100, nullable: false),
                    Folder_ID = table.Column<string>(maxLength: 10, nullable: false),
                    Text_Block = table.Column<string>(maxLength: 100, nullable: true),
                    Video = table.Column<string>(maxLength: 50, nullable: true),
                    Group_Signup = table.Column<string>(maxLength: 50, nullable: true),
                    Audio = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentAreas", x => new { x.ContentArea_ID, x.Folder_ID, x.Content_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_ContentAreas_Folders_Folder_ID_Content_ID_Course_ID",
                        columns: x => new { x.Folder_ID, x.Content_ID, x.Course_ID },
                        principalTable: "Folders",
                        principalColumns: new[] { "Folder_ID", "Content_ID", "Course_ID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_Course_ID",
                table: "Assignments",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_Teacher_ID",
                table: "Assignments",
                column: "Teacher_ID",
                unique: true,
                filter: "[Teacher_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_Course_ID",
                table: "Calendars",
                column: "Course_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentAreas_Folder_ID_Content_ID_Course_ID",
                table: "ContentAreas",
                columns: new[] { "Folder_ID", "Content_ID", "Course_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseContents_Course_ID",
                table: "CourseContents",
                column: "Course_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseResponsibles_Teacher_ID",
                table: "CourseResponsibles",
                column: "Teacher_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deadlines_Calendar_ID_Course_ID",
                table: "Deadlines",
                columns: new[] { "Calendar_ID", "Course_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Folders_Content_ID_Course_ID",
                table: "Folders",
                columns: new[] { "Content_ID", "Course_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_HandIns_Calendar_ID_Course_ID",
                table: "HandIns",
                columns: new[] { "Calendar_ID", "Course_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_IsAssignedTos_Course_ID",
                table: "IsAssignedTos",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_IsEnrolledTos_Course_ID",
                table: "IsEnrolledTos",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LectureDates_Calendar_ID_Course_ID",
                table: "LectureDates",
                columns: new[] { "Calendar_ID", "Course_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_TeachingAssistants_Teacher_ID",
                table: "TeachingAssistants",
                column: "Teacher_ID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "ContentAreas");

            migrationBuilder.DropTable(
                name: "CourseResponsibles");

            migrationBuilder.DropTable(
                name: "Deadlines");

            migrationBuilder.DropTable(
                name: "HandIns");

            migrationBuilder.DropTable(
                name: "IsAssignedTos");

            migrationBuilder.DropTable(
                name: "IsEnrolledTos");

            migrationBuilder.DropTable(
                name: "LectureDates");

            migrationBuilder.DropTable(
                name: "TeachingAssistants");

            migrationBuilder.DropTable(
                name: "Folders");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "CourseContents");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}

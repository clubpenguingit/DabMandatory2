using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DABMandatory2.Migrations
{
    public partial class DataSeedingAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                column: "Course_ID",
                values: new object[]
                {
                    "I4DAB",
                    "I4SWT"
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "AU_ID", "Birthday", "EnrollmentDate", "GraduationDate", "Name" },
                values: new object[,]
                {
                    { "au590761", new DateTime(1997, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andy" },
                    { "au000000", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2100, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Falsk studerende" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Teacher_ID", "AssistantOrResponsible" },
                values: new object[,]
                {
                    { "Troels", "Assistant" },
                    { "Henrik", "Responsible" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AU_ID", "Assignment_ID", "Course_ID", "Grade", "GroupSize", "Passed", "TIMESTAMP", "Teacher_ID" },
                values: new object[,]
                {
                    { "au590761", "ATMS", "I4SWT", 12, 4, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Troels" },
                    { "au590761", "EFCore", "I4DAB", 7, 4, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henrik" }
                });

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Calendar_ID", "Course_ID" },
                values: new object[] { "calendarid", "I4DAB" });

            migrationBuilder.InsertData(
                table: "CourseContents",
                columns: new[] { "Content_ID", "Course_ID" },
                values: new object[] { "contentid", "I4DAB" });

            migrationBuilder.InsertData(
                table: "CourseResponsibles",
                columns: new[] { "AU_ID", "Teacher_ID", "Birthday", "Name" },
                values: new object[] { "auid", "Henrik", new DateTime(2000, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andy Frækkesen" });

            migrationBuilder.InsertData(
                table: "IsAssignedTos",
                columns: new[] { "Teacher_ID", "Course_ID" },
                values: new object[,]
                {
                    { "Troels", "I4SWT" },
                    { "Henrik", "I4DAB" }
                });

            migrationBuilder.InsertData(
                table: "IsEnrolledTos",
                columns: new[] { "AU_ID", "Course_ID", "ActiveOrPassed", "Grade" },
                values: new object[,]
                {
                    { "au590761", "I4DAB", true, 12 },
                    { "au590761", "I4SWT", true, 2 }
                });

            migrationBuilder.InsertData(
                table: "TeachingAssistants",
                columns: new[] { "AU_ID", "Teacher_ID", "Birthday", "Name" },
                values: new object[] { "au123456", "Troels", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Troels" });

            migrationBuilder.InsertData(
                table: "Deadlines",
                columns: new[] { "DeadlineDate", "Calendar_ID", "Course_ID" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "calendarid", "I4DAB" });

            migrationBuilder.InsertData(
                table: "Folders",
                columns: new[] { "Folder_ID", "Content_ID", "Course_ID" },
                values: new object[] { "folderid", "contentid", "I4DAB" });

            migrationBuilder.InsertData(
                table: "HandIns",
                columns: new[] { "HandinDate", "Calendar_ID", "Course_ID" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "calendarid", "I4DAB" });

            migrationBuilder.InsertData(
                table: "LectureDates",
                columns: new[] { "Lecture", "Calendar_ID", "Course_ID" },
                values: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "calendarid", "I4DAB" });

            migrationBuilder.InsertData(
                table: "ContentAreas",
                columns: new[] { "ContentArea_ID", "Folder_ID", "Content_ID", "Course_ID", "Audio", "Group_Signup", "Text_Block", "Video" },
                values: new object[] { "contentareaid", "folderid", "contentid", "I4DAB", "audio.wav", "www.signup.com", "textblock", "video.mp4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumns: new[] { "AU_ID", "Assignment_ID" },
                keyValues: new object[] { "au590761", "ATMS" });

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumns: new[] { "AU_ID", "Assignment_ID" },
                keyValues: new object[] { "au590761", "EFCore" });

            migrationBuilder.DeleteData(
                table: "ContentAreas",
                keyColumns: new[] { "ContentArea_ID", "Folder_ID", "Content_ID", "Course_ID" },
                keyValues: new object[] { "contentareaid", "folderid", "contentid", "I4DAB" });

            migrationBuilder.DeleteData(
                table: "CourseResponsibles",
                keyColumns: new[] { "AU_ID", "Teacher_ID" },
                keyValues: new object[] { "auid", "Henrik" });

            migrationBuilder.DeleteData(
                table: "Deadlines",
                keyColumns: new[] { "DeadlineDate", "Calendar_ID", "Course_ID" },
                keyValues: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "calendarid", "I4DAB" });

            migrationBuilder.DeleteData(
                table: "HandIns",
                keyColumns: new[] { "HandinDate", "Calendar_ID", "Course_ID" },
                keyValues: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "calendarid", "I4DAB" });

            migrationBuilder.DeleteData(
                table: "IsAssignedTos",
                keyColumns: new[] { "Teacher_ID", "Course_ID" },
                keyValues: new object[] { "Henrik", "I4DAB" });

            migrationBuilder.DeleteData(
                table: "IsAssignedTos",
                keyColumns: new[] { "Teacher_ID", "Course_ID" },
                keyValues: new object[] { "Troels", "I4SWT" });

            migrationBuilder.DeleteData(
                table: "IsEnrolledTos",
                keyColumns: new[] { "AU_ID", "Course_ID" },
                keyValues: new object[] { "au590761", "I4DAB" });

            migrationBuilder.DeleteData(
                table: "IsEnrolledTos",
                keyColumns: new[] { "AU_ID", "Course_ID" },
                keyValues: new object[] { "au590761", "I4SWT" });

            migrationBuilder.DeleteData(
                table: "LectureDates",
                keyColumns: new[] { "Lecture", "Calendar_ID", "Course_ID" },
                keyValues: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "calendarid", "I4DAB" });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AU_ID",
                keyValue: "au000000");

            migrationBuilder.DeleteData(
                table: "TeachingAssistants",
                keyColumns: new[] { "AU_ID", "Teacher_ID" },
                keyValues: new object[] { "au123456", "Troels" });

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumns: new[] { "Calendar_ID", "Course_ID" },
                keyValues: new object[] { "calendarid", "I4DAB" });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Course_ID",
                keyValue: "I4SWT");

            migrationBuilder.DeleteData(
                table: "Folders",
                keyColumns: new[] { "Folder_ID", "Content_ID", "Course_ID" },
                keyValues: new object[] { "folderid", "contentid", "I4DAB" });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AU_ID",
                keyValue: "au590761");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Teacher_ID",
                keyValue: "Henrik");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Teacher_ID",
                keyValue: "Troels");

            migrationBuilder.DeleteData(
                table: "CourseContents",
                keyColumns: new[] { "Content_ID", "Course_ID" },
                keyValues: new object[] { "contentid", "I4DAB" });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Course_ID",
                keyValue: "I4DAB");
        }
    }
}

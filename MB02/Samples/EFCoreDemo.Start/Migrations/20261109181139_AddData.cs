using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreDemo.Start.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "City", "Mail", "MobilePhone", "Name", "Phone", "PostalCode" },
                values: new object[,]
                {
                    { 1, null, null, null, "Bill Gates", null, null },
                    { 2, null, null, null, "Anthony Alicea", null, null },
                    { 3, null, null, null, "Eric Wise", null, null },
                    { 4, null, null, null, "Tom Owsiak", null, null },
                    { 5, null, null, null, "John Smith", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "c#" },
                    { 2, "angularjs" },
                    { 3, "javascript" },
                    { 4, "nodejs" },
                    { 5, "oop" },
                    { 6, "linq" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "FullPrice", "Level", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "Description for C# Basics", 49.2m, 1, "C# Basics" },
                    { 2, 1, 1, "Description for C# Intermediate", 49.2m, 1, "C# Intermediate" },
                    { 3, 1, 1, "Description for C# Advanced", 69.9m, 3, "C# Advanced" },
                    { 4, 2, 1, "Description for Javascript", 149.0m, 2, "Javascript: Understanding the Weird Parts" },
                    { 5, 2, 1, "Description for AngularJS", 99m, 2, "Learn and Understand AngularJS" },
                    { 6, 2, 1, "Description for NodeJS", 149m, 3, "Learn and Understand NodeJS" },
                    { 7, 3, 1, "Description for Programming for Beginners", 45m, 3, "Programming for Complete Beginners" },
                    { 8, 4, 1, "Description 16 Hour Course", 150.9m, 1, "A 16 Hour C# Course with Visual Studio 2013" },
                    { 9, 4, 1, "Description Learn Javascript", 20m, 2, "Learn JavaScript Through Visual Studio 2013" }
                });

            migrationBuilder.InsertData(
                table: "CourseTags",
                columns: new[] { "CourseId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 5 },
                    { 3, 1 },
                    { 4, 3 },
                    { 5, 2 },
                    { 6, 4 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTags",
                keyColumns: new[] { "CourseId", "TagId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

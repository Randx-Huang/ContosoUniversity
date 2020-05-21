using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class AddDateModifiedColforDepartmentCoursePerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Person",
                type: "datetime",
                nullable: false,
                defaultValue: "(GetDate())");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Department",
                type: "datetime",
                nullable: false,
                defaultValue: "(GetDate())");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Course",
                type: "datetime",
                nullable: false,
                defaultValue: "(GetDate())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Course");
        }
    }
}

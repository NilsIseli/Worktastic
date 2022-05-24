using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Worktastic.Data.Migrations
{
    public partial class addedJobPostingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobPostings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ContactPhone = table.Column<string>(nullable: true),
                    ContactMail = table.Column<string>(nullable: true),
                    ContactWebsite = table.Column<string>(nullable: true),
                    CompanyImage = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostings", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobPostings");
        }
    }
}

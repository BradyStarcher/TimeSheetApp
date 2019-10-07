using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetApp.Data.Migrations
{
    public partial class TimesheetModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ApprovalTimeSheetStatus",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Division",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Payroll",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Manager_ApprovalTimeSheetStatus",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Manager_Division",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeClockID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payroll",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Salary = table.Column<decimal>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payroll", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payroll_AspNetUsers_User",
                        column: x => x.User,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimeClock",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClockIn = table.Column<DateTime>(nullable: false),
                    Lunch = table.Column<DateTime>(nullable: false),
                    ClockOut = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeClock", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Division",
                table: "AspNetUsers",
                column: "Division");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Payroll",
                table: "AspNetUsers",
                column: "Payroll");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Manager_Division",
                table: "AspNetUsers",
                column: "Manager_Division");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TimeClockID",
                table: "AspNetUsers",
                column: "TimeClockID");

            migrationBuilder.CreateIndex(
                name: "IX_Payroll_User",
                table: "Payroll",
                column: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Division_Division",
                table: "AspNetUsers",
                column: "Division",
                principalTable: "Division",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Payroll_Payroll",
                table: "AspNetUsers",
                column: "Payroll",
                principalTable: "Payroll",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Division_Manager_Division",
                table: "AspNetUsers",
                column: "Manager_Division",
                principalTable: "Division",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TimeClock_TimeClockID",
                table: "AspNetUsers",
                column: "TimeClockID",
                principalTable: "TimeClock",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Division_Division",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Payroll_Payroll",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Division_Manager_Division",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TimeClock_TimeClockID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "Payroll");

            migrationBuilder.DropTable(
                name: "TimeClock");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Division",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Payroll",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Manager_Division",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TimeClockID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApprovalTimeSheetStatus",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Division",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Payroll",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Manager_ApprovalTimeSheetStatus",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Manager_Division",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TimeClockID",
                table: "AspNetUsers");
        }
    }
}

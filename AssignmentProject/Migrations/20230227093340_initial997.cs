using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentProject.Migrations
{
    public partial class initial997 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_projects_userid",
                table: "projects",
                column: "userid");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_Users_userid",
                table: "projects",
                column: "userid",
                principalTable: "Users",
                principalColumn: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_Users_userid",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_userid",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "projects");
        }
    }
}

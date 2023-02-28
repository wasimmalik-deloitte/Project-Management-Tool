using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentProject.Migrations
{
    public partial class initial111567 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_Users_userid",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_userid",
                table: "projects");

            migrationBuilder.AddColumn<int>(
                name: "projectid",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_projectid",
                table: "Users",
                column: "projectid");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_projects_projectid",
                table: "Users",
                column: "projectid",
                principalTable: "projects",
                principalColumn: "projectid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_projects_projectid",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_projectid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "projectid",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_projects_userid",
                table: "projects",
                column: "userid");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_Users_userid",
                table: "projects",
                column: "userid",
                principalTable: "Users",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentProject.Migrations
{
    public partial class initial11156 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_Users_userid",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_userid",
                table: "projects");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentProject.Migrations
{
    public partial class initial9954 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_Users_userid",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_Users_usersuserid",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_usersuserid",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "usersuserid",
                table: "projects");

            migrationBuilder.AlterColumn<int>(
                name: "userid",
                table: "projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "userid",
                table: "projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "usersuserid",
                table: "projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_projects_usersuserid",
                table: "projects",
                column: "usersuserid");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_Users_userid",
                table: "projects",
                column: "userid",
                principalTable: "Users",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_Users_usersuserid",
                table: "projects",
                column: "usersuserid",
                principalTable: "Users",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

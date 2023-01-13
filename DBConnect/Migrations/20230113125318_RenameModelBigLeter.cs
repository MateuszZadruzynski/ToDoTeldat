using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBConnect.Migrations
{
    /// <inheritdoc />
    public partial class RenameModelBigLeter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_toDoTasks",
                table: "toDoTasks");

            migrationBuilder.RenameTable(
                name: "toDoTasks",
                newName: "ToDoTasks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoTasks",
                table: "ToDoTasks",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoTasks",
                table: "ToDoTasks");

            migrationBuilder.RenameTable(
                name: "ToDoTasks",
                newName: "toDoTasks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_toDoTasks",
                table: "toDoTasks",
                column: "Id");
        }
    }
}

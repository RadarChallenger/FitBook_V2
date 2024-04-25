using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitBook.Migrations
{
    /// <inheritdoc />
    public partial class WorkoutsForeignKeyUserIDFIX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Users_WorkoutID",
                table: "Workouts");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_UserID",
                table: "Workouts",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Users_UserID",
                table: "Workouts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Users_UserID",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_UserID",
                table: "Workouts");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Users_WorkoutID",
                table: "Workouts",
                column: "WorkoutID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

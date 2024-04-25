using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitBook.Migrations
{
    /// <inheritdoc />
    public partial class AddedFinishedWorkout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FinishWorkout",
                table: "Workouts",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinishWorkout",
                table: "Workouts");
        }
    }
}

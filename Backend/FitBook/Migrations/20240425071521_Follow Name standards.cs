using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitBook.Migrations
{
    /// <inheritdoc />
    public partial class FollowNamestandards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExercises_Exercises_ExerciseID",
                table: "WorkoutExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExercises_Workouts_WorkoutID",
                table: "WorkoutExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Users_UserID",
                table: "Workouts");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Workouts",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Endtime",
                table: "Workouts",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "WorkoutID",
                table: "Workouts",
                newName: "WorkoutId");

            migrationBuilder.RenameIndex(
                name: "IX_Workouts_UserID",
                table: "Workouts",
                newName: "IX_Workouts_UserId");

            migrationBuilder.RenameColumn(
                name: "WorkoutID",
                table: "WorkoutExercises",
                newName: "WorkoutId");

            migrationBuilder.RenameColumn(
                name: "ExerciseID",
                table: "WorkoutExercises",
                newName: "ExerciseId");

            migrationBuilder.RenameColumn(
                name: "WorkoutExerciseID",
                table: "WorkoutExercises",
                newName: "WorkoutExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkoutExercises_WorkoutID",
                table: "WorkoutExercises",
                newName: "IX_WorkoutExercises_WorkoutId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkoutExercises_ExerciseID",
                table: "WorkoutExercises",
                newName: "IX_WorkoutExercises_ExerciseId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ExerciseID",
                table: "Exercises",
                newName: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExercises_Exercises_ExerciseId",
                table: "WorkoutExercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "ExerciseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExercises_Workouts_WorkoutId",
                table: "WorkoutExercises",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "WorkoutId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Users_UserId",
                table: "Workouts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExercises_Exercises_ExerciseId",
                table: "WorkoutExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutExercises_Workouts_WorkoutId",
                table: "WorkoutExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Users_UserId",
                table: "Workouts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Workouts",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Workouts",
                newName: "Endtime");

            migrationBuilder.RenameColumn(
                name: "WorkoutId",
                table: "Workouts",
                newName: "WorkoutID");

            migrationBuilder.RenameIndex(
                name: "IX_Workouts_UserId",
                table: "Workouts",
                newName: "IX_Workouts_UserID");

            migrationBuilder.RenameColumn(
                name: "WorkoutId",
                table: "WorkoutExercises",
                newName: "WorkoutID");

            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "WorkoutExercises",
                newName: "ExerciseID");

            migrationBuilder.RenameColumn(
                name: "WorkoutExerciseId",
                table: "WorkoutExercises",
                newName: "WorkoutExerciseID");

            migrationBuilder.RenameIndex(
                name: "IX_WorkoutExercises_WorkoutId",
                table: "WorkoutExercises",
                newName: "IX_WorkoutExercises_WorkoutID");

            migrationBuilder.RenameIndex(
                name: "IX_WorkoutExercises_ExerciseId",
                table: "WorkoutExercises",
                newName: "IX_WorkoutExercises_ExerciseID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "Exercises",
                newName: "ExerciseID");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExercises_Exercises_ExerciseID",
                table: "WorkoutExercises",
                column: "ExerciseID",
                principalTable: "Exercises",
                principalColumn: "ExerciseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutExercises_Workouts_WorkoutID",
                table: "WorkoutExercises",
                column: "WorkoutID",
                principalTable: "Workouts",
                principalColumn: "WorkoutID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Users_UserID",
                table: "Workouts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

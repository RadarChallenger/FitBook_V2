using FitBook.Models;

namespace FitBook.Services;

public interface IWorkoutExerciseService
{
    ICollection<WorkoutExercise> GetWorkoutExercises();
    WorkoutExercise GetWorkoutExercise(Guid workoutExerciseID);
    bool CreateWorkoutExercise(WorkoutExercise newWorkoutExercise);
    bool DeleteWorkoutExercise(WorkoutExercise workoutExercise);
    bool UpdateWorkoutExercise(WorkoutExercise workoutExercise);
    public ICollection<WorkoutExercise> GetExercisesFromWorkout(Guid workoutID);
}
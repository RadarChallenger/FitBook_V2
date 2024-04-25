using FitBook.Models;

namespace FitBook.Services;

public interface IWorkoutService
{
    ICollection<Workout> GetWorkouts();
    Workout GetWorkout(Guid workoutID);
    bool CreateWorkout(Workout newWorkout, Guid id);
    bool DeleteWorkout(Workout workout);
    bool UpdateWorkout(Workout workout);
}
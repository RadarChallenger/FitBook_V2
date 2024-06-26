using FitBook.Data;
using FitBook.Models;

namespace FitBook.Services;

public class WorkoutService : BaseService, IWorkoutService
{
    public WorkoutService(ApiDbContext context)
    {
        Context = context;
    }

    public ICollection<Workout> GetWorkouts()
    {
        return Context.Workouts.ToList();
    }

    public Workout GetWorkout(Guid workoutId)
    {
        return Context.Workouts.First(w => w.WorkoutId == workoutId);
    }

    public bool CreateWorkout(Workout newWorkout, Guid id)
    {
        newWorkout.WorkoutId = id;
        Context.Add(newWorkout);
        return Save();
    }

    public bool DeleteWorkout(Workout workout)
    {
        Context.Remove(workout);
        return Save();
    }

    public bool UpdateWorkout(Workout workout)
    {
        Context.Update(workout);
        return Save();
    }
}
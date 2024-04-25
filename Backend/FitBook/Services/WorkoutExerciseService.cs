using FitBook.Data;
using FitBook.Models;

namespace FitBook.Services;

public class WorkoutExerciseService : BaseService, IWorkoutExerciseService
{
    public WorkoutExerciseService(ApiDbContext context)
    {
        Context = context;
    }

    public ICollection<WorkoutExercise> GetWorkoutExercises()
    {
        return Context.WorkoutExercises.ToList();
    }

    public WorkoutExercise GetWorkoutExercise(Guid workoutExerciseId)
    {
        return Context.WorkoutExercises.First(we => we.WorkoutExerciseId == workoutExerciseId);
    }

    public ICollection<WorkoutExercise> GetExercisesFromWorkout(Guid workoutId)
    {
        return Context.WorkoutExercises.Where(we => we.WorkoutId == workoutId).ToList();
    }

    public bool CreateWorkoutExercise(WorkoutExercise newWorkoutExercise)
    {
        newWorkoutExercise.WorkoutExerciseId = Guid.NewGuid();
        Context.Add(newWorkoutExercise);
        return Save();
    }

    public bool DeleteWorkoutExercise(WorkoutExercise workoutExercise)
    {
        Context.Remove(workoutExercise);
        return Save();
    }

    public bool UpdateWorkoutExercise(WorkoutExercise workoutExercise)
    {
        Context.Update(workoutExercise);
        return Save();
    }
}
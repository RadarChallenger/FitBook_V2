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

    public WorkoutExercise GetWorkoutExercise(Guid workoutExerciseID)
    {
        return Context.WorkoutExercises.FirstOrDefault(we => we.WorkoutExerciseID == workoutExerciseID);
    }

    public ICollection<WorkoutExercise> GetExercisesFromWorkout(Guid workoutID)
    {
        return Context.WorkoutExercises.Where(we => we.WorkoutID == workoutID).ToList();
    }

    public bool CreateWorkoutExercise(WorkoutExercise newWorkoutExercise)
    {
        newWorkoutExercise.WorkoutExerciseID = Guid.NewGuid();
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
using FitBook.Data;
using FitBook.Models;

namespace FitBook.Services;

public class WorkoutExerciseService : IWorkoutExerciseService
{
    private ApiDbContext Context;

    public WorkoutExerciseService(ApiDbContext context)
    {
        Context = context;
    }

    public ICollection<WorkoutExercise> GetWorkoutExercises()
    {
        return new List<WorkoutExercise>();
    }
}
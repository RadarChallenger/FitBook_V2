using FitBook.Data;
using FitBook.Models;

namespace FitBook.Services;

public class WorkoutService : IWorkoutService
{
    private ApiDbContext Context;

    public WorkoutService(ApiDbContext context)
    {
        Context = context;
    }

    public ICollection<Workout> GetWorkouts()
    {
        return new List<Workout>();
    }
}
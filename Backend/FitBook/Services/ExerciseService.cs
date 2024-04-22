using FitBook.Data;
using FitBook.Models;

namespace FitBook.Services;

public class ExerciseService : IExerciseService
{
    private ApiDbContext Context;

    public ExerciseService(ApiDbContext context)
    {
        Context = context;
    }

    public ICollection<Exercise> GetExercises()
    {
        return new List<Exercise>();
    }
}
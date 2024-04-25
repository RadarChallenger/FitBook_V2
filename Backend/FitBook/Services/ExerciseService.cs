using FitBook.Data;
using FitBook.Models;

namespace FitBook.Services;

public class ExerciseService : BaseService, IExerciseService
{
    public ExerciseService(ApiDbContext context)
    {
        Context = context;
    }

    public ICollection<Exercise> GetExercises()
    {
        return Context.Exercises.ToList();
    }

    public Exercise GetExercise(Guid exerciseId)
    {
        return Context.Exercises.First(e => e.ExerciseId == exerciseId);
    }

    public bool CreateExercise(Exercise newExercise)
    {
        newExercise.ExerciseId = Guid.NewGuid();
        Context.Add(newExercise);
        return Save();
    }

    public bool DeleteExercise(Exercise exercise)
    {
        Context.Remove(exercise);
        return Save();
    }

    public bool UpdateExercise(Exercise exercise)
    {
        Context.Update(exercise);
        return Save();
    }
}
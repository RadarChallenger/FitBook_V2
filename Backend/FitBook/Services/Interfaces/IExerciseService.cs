using FitBook.Models;

namespace FitBook.Services;

public interface IExerciseService
{
    ICollection<Exercise> GetExercises();
    Exercise GetExercise(Guid exerciseID);
    bool CreateExercise(Exercise newExercise);
    bool DeleteExercise(Exercise exercise);
    bool UpdateExercise(Exercise exercise);
}
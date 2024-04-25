namespace FitBook.Models;

public class Exercise
{
    public string Name { get; set; }
    public Guid ExerciseId { get; set; }
    public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
}
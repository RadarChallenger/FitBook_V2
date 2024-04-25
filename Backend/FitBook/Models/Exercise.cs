namespace FitBook.Models;

public class Exercise
{
    public string Name { get; set; }
    public Guid ExerciseID { get; set; }
    public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
}
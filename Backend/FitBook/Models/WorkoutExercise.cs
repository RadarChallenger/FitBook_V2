namespace FitBook.Models;

public class WorkoutExercise
{
    public Guid WorkoutExerciseId { get; set; }
    public int Sets { get; set; }
    public int Repetition { get; set; }
    public int Weight { get; set; }
    public Guid ExerciseId { get; set; }
    public Guid WorkoutId { get; set; }
    public Exercise Exercise { get; set; }
    public Workout Workout { get; set; }
}
namespace FitBook.Models;

public class WorkoutExercise
{
    public Guid WorkoutExerciseID { get; set; }
    public int Sets { get; set; }
    public int Repetition { get; set; }
    public int Weight { get; set; }
    public Guid ExerciseID { get; set; }
    public Guid WorkoutID { get; set; }
    public Exercise Exercise { get; set; }
    public Workout Workout { get; set; }
}
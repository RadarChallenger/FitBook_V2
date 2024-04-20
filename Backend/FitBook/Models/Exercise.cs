namespace FitBook.Models;

public class Exercise
{
    public string Name { get; set; }
    public Guid ExerciseID { get; set; }
    public ICollection<Workout> Workouts { get; set; }
}
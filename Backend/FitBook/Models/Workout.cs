namespace FitBook.Models;

public class Workout
{
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime Endtime { get; set; }
    public Guid WorkoutID { get; set; }
    public Guid UserID { get; set; }
    public User User { get; set; }
    public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
}
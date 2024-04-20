namespace FitBook.Models;

public class Workout
{
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime Endtime { get; set; }
    public Guid WorkoutID { get; set; }
    public User User { get; set; }
    public ICollection<Exercise> Exercises { get; set; }
}
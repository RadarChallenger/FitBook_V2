namespace FitBook.Models;

public class Workout
{
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Guid WorkoutId { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
}
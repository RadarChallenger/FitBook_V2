namespace FitBook.Models;

public class Workout
{
    public Workout()
    {
    }

    public string Name;
    private List<Exercise> Exercises;
    private DateTime StartTime;
    private DateTime Endtime;
    private Guid WorkoutID;
}
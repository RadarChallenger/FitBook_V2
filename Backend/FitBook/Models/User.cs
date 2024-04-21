namespace FitBook.Models;

public class User
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public Guid UserID { get; set; }
    public ICollection<Workout> Workouts { get; set; }
}
namespace FitBook.Models;

public class User
{
    public string UserName { get; set; }
    private string Password { get; set; }
    public Guid UserID { get; set; }
    public ICollection<Workout> Workouts { get; set; }
}
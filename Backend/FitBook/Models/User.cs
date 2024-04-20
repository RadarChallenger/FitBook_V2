namespace FitBook.Models;

public class User
{
    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
        UserID = new Guid();
    }
    
    public string UserName;
    private string Password;
    private Guid UserID;
    private List<Workout> WorkoutHistory;
}
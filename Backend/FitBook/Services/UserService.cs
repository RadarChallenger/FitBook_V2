using FitBook.Models;

namespace FitBook.Services;

public class UserService : IUserService
{
    public ICollection<User> GetUsers()
    {
        return new List<User>()
        {
            new User() { UserName = "Radar", UserID = Guid.NewGuid(), Password = "1234" }
        };
    }
}
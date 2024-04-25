using FitBook.Models;

namespace FitBook.Services;

public interface IUserService
{
    ICollection<User> GetUsers();
    User GetUser(Guid userID);
    bool CreateUser(User newUser);
    bool DeleteUser(User user);
    bool UpdateUser(User user);
}
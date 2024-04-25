using FitBook.Data;
using FitBook.Models;

namespace FitBook.Services;

public class UserService : BaseService, IUserService
{
    public UserService(ApiDbContext context)
    {
        Context = context;
    }
    
    public ICollection<User> GetUsers()
    {
        return Context.Users.ToList();
    }

    public User GetUser(Guid userId)
    {
        return Context.Users.First(u => u.UserId == userId);
    }

    public bool CreateUser(User newUser)
    {
        newUser.UserId = Guid.NewGuid();
        Context.Add(newUser);
        return Save();
    }

    public bool DeleteUser(User user)
    {
        Context.Remove(user);
        return Save();
    }

    public bool UpdateUser(User user)
    {
        Context.Update(user);
        return Save();
    }
}
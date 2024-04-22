using FitBook.Data;
using FitBook.Models;

namespace FitBook.Services;

public class UserService : IUserService
{
    private ApiDbContext Context;

    public UserService(ApiDbContext context)
    {
        Context = context;
    }
    public ICollection<User> GetUsers()
    {
        return new List<User>();
    }
}
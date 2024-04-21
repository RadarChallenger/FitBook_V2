using FitBook.Models;

namespace FitBook.Services;

public interface IUserService
{
    public ICollection<User> GetUsers();
}
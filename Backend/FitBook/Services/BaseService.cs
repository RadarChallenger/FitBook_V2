using FitBook.Data;

namespace FitBook.Services;

public abstract class BaseService : IService
{
    protected ApiDbContext Context; 
    
    public bool Save()
    {
        var saved = Context.SaveChanges();
        return saved > 0 ? true : false;
    }
}
namespace FitBook.Dtos;

public class ResponseUserDto
{
    public string UserName { get; set; } = string.Empty;
    public Guid UserID { get; set; } = Guid.Empty;
}

public class CreateUserDto
{
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
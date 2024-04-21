using AutoMapper;
using FitBook.Dtos;
using FitBook.Models;
using FitBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitBook.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private IUserService UserService;
    private IMapper Mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        UserService = userService;
        Mapper = mapper;
    }
    
    [HttpPost("CreateUser")]
    public ActionResult CreateUser([FromBody] User newUser)
    {
        // Implement Create-user logic here
        throw new NotImplementedException();
    }

    [HttpPost("UserSignIn")]
    public ActionResult SignIn([FromBody] User loginUser)
    {
        // Implement sign-in logic here
        throw new NotImplementedException();
    }

    [HttpPost("UserSignOut")]
    public ActionResult UserSignOut()
    {
        // Implement sign-out logic here
        throw new NotImplementedException();
    }

    [HttpDelete("DeleteUser/{userId}")]
    public ActionResult DeleteUser(Guid userId)
    {
        // Implement delete user logic here
        throw new NotImplementedException();
    }

    [HttpGet("GetUser/{userId}")]
    public ActionResult GetUser(Guid userId)
    {
        // Implement get user logic here
        throw new NotImplementedException();
    }
    
    [HttpGet("GetUsers")]
    public ActionResult<ICollection<User>> GetUsers()
    {
        var users = UserService.GetUsers();
        return Ok(users.Select(user => Mapper.Map<UserDto>(user)));
    }
}
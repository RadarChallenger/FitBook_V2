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
    public ActionResult CreateUser([FromBody] CreateUserDto newUser)
    {
        var user = Mapper.Map<User>(newUser);
        if (UserService.CreateUser(user))
        {
            return Ok();
        }
        else
        {
            return BadRequest();
        }
    }

    [HttpDelete("DeleteUser/{userId}")]
    public ActionResult DeleteUser(Guid userId)
    {
        var user = UserService.GetUser(userId);
        UserService.DeleteUser(user);
        return Ok();
    }

    [HttpGet("GetUser/{userId}")]
    public ActionResult GetUser(Guid userId)
    {
        var user = UserService.GetUser(userId);
        return Ok(Mapper.Map<ResponseUserDto>(user));
    }
    
    [HttpGet("GetUsers")]
    public ActionResult<ICollection<ResponseUserDto>> GetUsers()
    {
        var users = UserService.GetUsers();
        return Ok(users.Select(user => Mapper.Map<ResponseUserDto>(user)));
    }
}
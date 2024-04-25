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
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }
    
    [HttpPost("CreateUser")]
    public ActionResult CreateUser([FromBody] CreateUserDto newUser)
    {
        var user = _mapper.Map<User>(newUser);
        if (_userService.CreateUser(user))
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
        var user = _userService.GetUser(userId);
        _userService.DeleteUser(user);
        return Ok();
    }

    [HttpGet("GetUser/{userId}")]
    public ActionResult GetUser(Guid userId)
    {
        var user = _userService.GetUser(userId);
        return Ok(_mapper.Map<ResponseUserDto>(user));
    }
    
    [HttpGet("GetUsers")]
    public ActionResult<ICollection<ResponseUserDto>> GetUsers()
    {
        var users = _userService.GetUsers();
        return Ok(users.Select(user => _mapper.Map<ResponseUserDto>(user)));
    }
}
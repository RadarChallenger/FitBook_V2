using FitBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitBook.Controllers;

public class UserController : ControllerBase
{
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
}
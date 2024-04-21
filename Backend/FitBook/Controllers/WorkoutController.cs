using FitBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitBook.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkoutController : ControllerBase
{
    [HttpPost("CreateWorkout")]
    public ActionResult CreateWorkout([FromBody] Workout newWorkout)
    {
        // Implement create workout logic here
        throw new NotImplementedException();
    }
    
    [HttpGet("GetWorkout/{workoutId}")]
    public ActionResult GetWorkout(Guid workoutId)
    {
        // Implement get workout logic here
        throw new NotImplementedException();
    }

    [HttpGet("GetWorkouts")]
    public ActionResult<IEnumerable<Workout>> GetWorkouts()
    {
        // Implement get workouts logic here
        throw new NotImplementedException();
    }

    [HttpDelete("DeleteWorkout/{workoutId}")]
    public ActionResult DeleteWorkout(Guid workoutId)
    {
        // Implement delete workout logic here
        throw new NotImplementedException();
    }

    [HttpPost("StartWorkout/{workoutId}")]
    public ActionResult StartWorkout(Guid workoutId)
    {
        // Implement start workout logic here
        throw new NotImplementedException();
    }

    [HttpPost("EndWorkout/{workoutId}")]
    public ActionResult EndWorkout(Guid workoutId)
    {
        // Implement end workout logic here
        throw new NotImplementedException();
    }

    [HttpPost("CancelWorkout/{workoutId}")]
    public ActionResult CancelWorkout(Guid workoutId)
    {
        // Implement cancel workout logic here
        throw new NotImplementedException();
    }

    [HttpPost("ImportWorkout")]
    public ActionResult ImportWorkout([FromBody] Workout importedWorkout)
    {
        // Implement import workout logic here
        throw new NotImplementedException();
    }

    [HttpPost("ExportWorkout/{workoutId}")]
    public ActionResult ExportWorkout(Guid workoutId)
    {
        // Implement export workout logic here
        throw new NotImplementedException();
    }
}
using AutoMapper;
using FitBook.Models;
using FitBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitBook.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExerciseController
{
    private readonly IExerciseService ExerciseService;
    private readonly IWorkoutExerciseService WorkoutExerciseService;
    private readonly IMapper Mapper;

    public ExerciseController(IExerciseService exerciseService, IWorkoutExerciseService workoutExerciseService, IMapper mapper)
    {
        ExerciseService = exerciseService;
        WorkoutExerciseService = workoutExerciseService;
        Mapper = mapper;
    }
    
    [HttpPost("CreateExercise")]
    public ActionResult CreateExercise([FromBody] Exercise newExercise)
    {
        // Implement create exercise logic here
        throw new NotImplementedException();
    }

    [HttpDelete("DeleteExercise/{exerciseId}")]
    public ActionResult DeleteExercise(Guid exerciseId)
    {
        // Implement delete exercise logic here
        throw new NotImplementedException();
    }

    [HttpPut("UpdateExercise")]
    public ActionResult UpdateExercise([FromBody] Exercise updatedExercise)
    {
        // Implement update exercise logic here
        throw new NotImplementedException();
    }

    [HttpGet("GetExercise/{exerciseId}")]
    public ActionResult GetExercise(Guid exerciseId)
    {
        // Implement get exercise by ID logic here
        throw new NotImplementedException();
    }

    [HttpGet("GetExercises")]
    public ActionResult<IEnumerable<Exercise>> GetExercises()
    {
        // Implement get exercises logic here
        throw new NotImplementedException();
    }
}
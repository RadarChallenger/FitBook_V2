using AutoMapper;
using FitBook.Dtos;
using FitBook.Models;
using FitBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitBook.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExerciseController : ControllerBase
{
    private readonly IExerciseService ExerciseService;
    private readonly IMapper Mapper;

    public ExerciseController(IExerciseService exerciseService, IMapper mapper)
    {
        ExerciseService = exerciseService;
        Mapper = mapper;
    }
    
    [HttpPost("CreateExercise")]
    public ActionResult CreateExercise([FromBody] CreateExerciseDto newExercise)
    {
        var exercise = Mapper.Map<Exercise>(newExercise);
        if (ExerciseService.CreateExercise(exercise))
        {
            return Ok();
        }
        else
        {
            return BadRequest();
        }
    }

    [HttpDelete("DeleteExercise/{exerciseId}")]
    public ActionResult DeleteExercise(Guid exerciseId)
    {
        var exercise = ExerciseService.GetExercise(exerciseId);
        ExerciseService.DeleteExercise(exercise);
        return Ok();
    }

    [HttpGet("GetExercise/{exerciseId}")]
    public ActionResult GetExercise(Guid exerciseId)
    {
        var exercise = ExerciseService.GetExercise(exerciseId);
        return Ok(Mapper.Map<RepsonseExerciseDto>(exercise));
    }

    [HttpGet("GetExercises")]
    public ActionResult<IEnumerable<RepsonseExerciseDto>> GetExercises()
    {
        var exercises = ExerciseService.GetExercises();
        return Ok(exercises.Select(exercise => Mapper.Map<RepsonseExerciseDto>(exercise)));
    }
}
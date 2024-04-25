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
    private readonly IExerciseService _exerciseService;
    private readonly IMapper _mapper;

    public ExerciseController(IExerciseService exerciseService, IMapper mapper)
    {
        _exerciseService = exerciseService;
        _mapper = mapper;
    }
    
    [HttpPost("CreateExercise")]
    public ActionResult CreateExercise([FromBody] CreateExerciseDto newExercise)
    {
        var exercise = _mapper.Map<Exercise>(newExercise);
        if (_exerciseService.CreateExercise(exercise))
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
        var exercise = _exerciseService.GetExercise(exerciseId);
        _exerciseService.DeleteExercise(exercise);
        return Ok();
    }

    [HttpGet("GetExercise/{exerciseId}")]
    public ActionResult GetExercise(Guid exerciseId)
    {
        var exercise = _exerciseService.GetExercise(exerciseId);
        return Ok(_mapper.Map<ResponseExerciseDto>(exercise));
    }

    [HttpGet("GetExercises")]
    public ActionResult<IEnumerable<ResponseExerciseDto>> GetExercises()
    {
        var exercises = _exerciseService.GetExercises();
        return Ok(exercises.Select(exercise => _mapper.Map<ResponseExerciseDto>(exercise)));
    }
}
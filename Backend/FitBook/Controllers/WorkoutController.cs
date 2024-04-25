using AutoMapper;
using FitBook.Dtos;
using FitBook.Models;
using FitBook.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitBook.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkoutController : ControllerBase
{
    private readonly IWorkoutService _workoutService;
    private readonly IWorkoutExerciseService _workoutExerciseService;
    private readonly IMapper _mapper;

    public WorkoutController(IWorkoutService workoutService, IWorkoutExerciseService workoutExerciseService, IMapper mapper)
    {
        _workoutService = workoutService;
        _workoutExerciseService = workoutExerciseService;
        _mapper = mapper;
    }

    [HttpPost("CreateWorkout")]
    public ActionResult CreateWorkout([FromQuery] Guid userId, [FromBody] CreateWorkoutDto newWorkout)
    {
        var workoutId = Guid.NewGuid();
        
        var workout = _mapper.Map<Workout>(newWorkout);
        workout.UserId = userId;
        _workoutService.CreateWorkout(workout, workoutId);
        
        var exercises = newWorkout.Exercises.Select(e => _mapper.Map<WorkoutExercise>(e));
        
        foreach (var workoutExercise in exercises)
        {
            workoutExercise.WorkoutId = workoutId;
            _workoutExerciseService.CreateWorkoutExercise(workoutExercise);
        }
        
        return Ok();
    }

    [HttpDelete("DeleteWorkout/{workoutId}")]
    public ActionResult DeleteWorkout(Guid workoutId)
    {
        var workoutExercises = _workoutExerciseService.GetExercisesFromWorkout(workoutId);
        foreach (var workoutExercise in workoutExercises)
        {
            _workoutExerciseService.DeleteWorkoutExercise(workoutExercise);
        }

        var workout = _workoutService.GetWorkout(workoutId);
        _workoutService.DeleteWorkout(workout);
        
        return Ok();
    }

    [HttpGet("GetWorkout/{workoutId}")]
    public ActionResult GetWorkout(Guid workoutId)
    {
        var workout = _workoutService.GetWorkout(workoutId);
        var workoutExercises = _workoutExerciseService.GetExercisesFromWorkout(workoutId);
        var exercisesDto = workoutExercises.Select(e => _mapper.Map<WorkoutExerciseDto>(e));
        var workoutDto = _mapper.Map<ResponseWorkoutDto>(workout);
        workoutDto.Exercises = exercisesDto;
        return Ok(workoutDto);
    }

    [HttpGet("GetWorkouts")]
    public ActionResult<IEnumerable<ResponseWorkoutDto>> GetWorkouts()
    {
        var result = new List<ResponseWorkoutDto>();
        var workouts = _workoutService.GetWorkouts();
        foreach (var workout in workouts)
        {
            var workoutExercises = _workoutExerciseService.GetExercisesFromWorkout(workout.WorkoutId);
            var exercisesDto = workoutExercises.Select(e => _mapper.Map<WorkoutExerciseDto>(e));
            var workoutDto = _mapper.Map<ResponseWorkoutDto>(workout);
            workoutDto.Exercises = exercisesDto;
            result.Add(workoutDto);
        }
        return Ok(result);
    }

    [HttpPost("FinishWorkout")]
    public ActionResult FinishWorkout([FromQuery] Guid workoutId)
    {
        var workout = _workoutService.GetWorkout(workoutId);
        workout.FinishWorkout = true;
        _workoutService.UpdateWorkout(workout);

        return Ok();
    }

    [HttpPost("AddExercisesToWorkout")]
    public ActionResult AddExercisesToWorkout([FromQuery] Guid workoutId, [FromBody] IEnumerable<WorkoutExerciseDto> workoutExercises)
    {
        var workout = _workoutService.GetWorkout(workoutId);
        workout.EndTime = DateTime.Now;
        _workoutService.UpdateWorkout(workout);
        
        var exercises = workoutExercises.Select(we => _mapper.Map<WorkoutExercise>(we));
        foreach (var exercise in exercises)
        {
            exercise.WorkoutId = workoutId;
            _workoutExerciseService.CreateWorkoutExercise(exercise);
        }

        return Ok();
    }
}
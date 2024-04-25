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
    private readonly IWorkoutService WorkoutService;
    private readonly IWorkoutExerciseService WorkoutExerciseService;
    private readonly IMapper Mapper;

    public WorkoutController(IWorkoutService workoutService, IWorkoutExerciseService workoutExerciseService, IMapper mapper)
    {
        WorkoutService = workoutService;
        WorkoutExerciseService = workoutExerciseService;
        Mapper = mapper;
    }

    [HttpPost("CreateWorkout")]
    public ActionResult CreateWorkout([FromQuery] Guid userID, [FromBody] CreateWorkoutDto newWorkout)
    {
        var workoutID = Guid.NewGuid();
        
        var workout = Mapper.Map<Workout>(newWorkout);
        workout.UserID = userID;
        WorkoutService.CreateWorkout(workout, workoutID);
        
        var exercises = newWorkout.Exercises.Select(e => Mapper.Map<WorkoutExercise>(e));
        
        foreach (var workoutExercise in exercises)
        {
            workoutExercise.WorkoutID = workoutID;
            WorkoutExerciseService.CreateWorkoutExercise(workoutExercise);
        }
        
        return Ok();
    }

    [HttpDelete("DeleteWorkout/{workoutId}")]
    public ActionResult DeleteWorkout(Guid workoutId)
    {
        var workoutExercises = WorkoutExerciseService.GetExercisesFromWorkout(workoutId);
        workoutExercises.Select(we => WorkoutExerciseService.DeleteWorkoutExercise(we));

        var workout = WorkoutService.GetWorkout(workoutId);
        WorkoutService.DeleteWorkout(workout);
        
        return Ok();
    }

    [HttpGet("GetWorkout/{workoutId}")]
    public ActionResult GetWorkout(Guid workoutId)
    {
        var workout = WorkoutService.GetWorkout(workoutId);
        var workoutExercises = WorkoutExerciseService.GetExercisesFromWorkout(workoutId);
        var exercisesDto = workoutExercises.Select(e => Mapper.Map<WorkoutExerciseDto>(e));
        var workoutDto = Mapper.Map<ResponseWorkoutDto>(workout);
        workoutDto.Exercises = exercisesDto;
        return Ok(workoutDto);
    }

    [HttpGet("GetWorkouts")]
    public ActionResult<IEnumerable<ResponseWorkoutDto>> GetWorkouts()
    {
        var result = new List<ResponseWorkoutDto>();
        var workouts = WorkoutService.GetWorkouts();
        foreach (var workout in workouts)
        {
            var workoutExercises = WorkoutExerciseService.GetExercisesFromWorkout(workout.WorkoutID);
            var exercisesDto = workoutExercises.Select(e => Mapper.Map<WorkoutExerciseDto>(e));
            var workoutDto = Mapper.Map<ResponseWorkoutDto>(workout);
            workoutDto.Exercises = exercisesDto;
            result.Add(workoutDto);
        }
        return Ok(result);
    }
}
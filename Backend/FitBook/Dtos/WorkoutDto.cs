namespace FitBook.Dtos;

public class CreateWorkoutDto
{
    public string Name { get; set; } = string.Empty;
    public DateTime StartTime { get; set; } = DateTime.UtcNow;
    public IEnumerable<WorkoutExerciseDto> Exercises { get; set; } = new List<WorkoutExerciseDto>();
}

public class ResponseWorkoutDto
{
    public string Name { get; set; } = string.Empty;
    public Guid WorkoutId { get; set; } = Guid.Empty;
    public Guid UserId { get; set; } = Guid.Empty;
    public DateTime StartTime { get; set; } = DateTime.UtcNow;
    public DateTime EndTime { get; set; } = DateTime.UtcNow;
    public bool FinishWorkout { get; set; } = false;
    public IEnumerable<WorkoutExerciseDto> Exercises { get; set; } = new List<WorkoutExerciseDto>();
}
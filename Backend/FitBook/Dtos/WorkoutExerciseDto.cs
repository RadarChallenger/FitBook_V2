namespace FitBook.Dtos;

public class WorkoutExerciseDto
{
    public Guid ExerciseId { get; set; } = Guid.Empty;
    public int Sets { get; set; } = 0;
    public int Repetition { get; set; } = 0;
    public int Weight { get; set; } = 0;
}
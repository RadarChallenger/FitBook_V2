namespace FitBook.Dtos;

public class CreateExerciseDto
{
    public string Name { get; set; } = string.Empty;
}

public class ResponseExerciseDto
{
    public string Name { get; set; } = string.Empty;
    public Guid ExerciseId { get; set; } = Guid.Empty;
}
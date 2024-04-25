namespace FitBook.Dtos;

public class CreateExerciseDto
{
    public string Name { get; set; } = string.Empty;
}

public class RepsonseExerciseDto
{
    public string Name { get; set; } = string.Empty;
    public Guid ExerciseID { get; set; } = Guid.Empty;
}
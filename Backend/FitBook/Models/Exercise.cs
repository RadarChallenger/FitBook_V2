namespace FitBook.Models;

public class Exercise
{
    public Exercise(string name, int sets, int repetition, int weight)
    {
        Name = name;
        Sets = sets;
        Repetition = repetition;
        Weight = Weight;
        ExerciseID = new Guid();
    }

    public string Name;
    public int Sets;
    public int Repetition;
    public int Weight;
    private Guid ExerciseID;
}
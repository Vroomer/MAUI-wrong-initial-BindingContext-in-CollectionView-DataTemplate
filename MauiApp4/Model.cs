namespace MauiApp4;

public class Model
{
    public Model(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; set; }
    public string Description { get; set; }
}

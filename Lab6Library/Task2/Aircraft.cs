namespace Lab6.Task2;

public class Aircraft
{
    public string Name;
    public bool IsTakingOff { get; set; }

    public Aircraft(string name)
    {
        this.Name = name;
    }
}
namespace Lab6.Task2;

public class CommandCentre
{
    private List<Runway> _runways = new List<Runway>();
    private List<Aircraft> _aircrafts = new List<Aircraft>();

    public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
    {
        this._runways.AddRange(runways);
        this._aircrafts.AddRange(aircrafts);
    }

    public void Land(Aircraft aircraft, Runway runway)
    {
        Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
        Console.WriteLine($"Checking runway.");
        if (runway.IsBusyWithAircraft == null)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
            runway.IsBusyWithAircraft = aircraft;
            runway.HighLightRed();
        }
        else
        {
            Console.WriteLine($"Could not land, the runway is busy.");
        }
    }

    public void TakeOff(Aircraft aircraft, Runway runway)
    {
        Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
        runway.IsBusyWithAircraft = null;
        runway.HighLightGreen();
        Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
    }
}
namespace Lab6;

public class LevelFourHandler : SupportHandler
{
    public override void HandleRequest(int request)
    {
        if (request == 4)
        {
            Console.WriteLine("Level Four Handler");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine("Invalid Level. Please try again.");
        }
    }
}
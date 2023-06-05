namespace Lab6;

public class LevelTwoHandler : SupportHandler
{
    public override void HandleRequest(int request)
    {
        if (request == 2)
            Console.WriteLine("Level Two Handler");
        else if (nextHandler != null)
            nextHandler.HandleRequest(request);
    }
}
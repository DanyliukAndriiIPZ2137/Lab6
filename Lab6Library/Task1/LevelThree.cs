namespace Lab6;

public class LevelThreeHandler : SupportHandler
{
    public override void HandleRequest(int request)
    {
        if (request == 3)
            Console.WriteLine("Level Three Handler");
        else if (nextHandler != null)
            nextHandler.HandleRequest(request);
    }
}
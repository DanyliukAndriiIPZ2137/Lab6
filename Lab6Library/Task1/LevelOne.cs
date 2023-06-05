namespace Lab6;

public class LevelOneHandler : SupportHandler
{
    public override void HandleRequest(int request)
    {
        if (request == 1)
            Console.WriteLine("Level One Handler");
        else if (nextHandler != null)
            nextHandler.HandleRequest(request);
    }
}

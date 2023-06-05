using Lab6;
using Lab6.Task2;

Console.WriteLine("1) Task 1\n2) Task 2\n3) Task 3\n4) Task 4");
int choise = Int32.Parse(Console.ReadLine());

switch (choise)
{
    case 1:
        SupportHandler levelOne = new LevelOneHandler();
        SupportHandler levelTwo = new LevelTwoHandler();
        SupportHandler levelThree = new LevelThreeHandler();
        SupportHandler levelFour = new LevelFourHandler();

        levelOne.SetNextHandler(levelTwo);
        levelTwo.SetNextHandler(levelThree);
        levelThree.SetNextHandler(levelFour);

        int level = 1;
        while (true)
        {
            Console.WriteLine($"Enter the level of support you need (1-4):");
            level = Convert.ToInt32(Console.ReadLine());
            levelOne.HandleRequest(level);

            Console.WriteLine("Do you want to continue? (yes/no)");
            string response = Console.ReadLine();

            if(response.ToLower() == "no")
            {
                break;
            }
        }
        break;
    case 2:
        Aircraft aircraft1 = new Aircraft("Aircraft1");
        Aircraft aircraft2 = new Aircraft("Aircraft2");

        Runway runway1 = new Runway();
        Runway runway2 = new Runway();

        CommandCentre commandCentre = new CommandCentre(new Runway[] { runway1, runway2 }, new Aircraft[] { aircraft1, aircraft2 });

        commandCentre.Land(aircraft1, runway1);
        commandCentre.TakeOff(aircraft1, runway1);
        break;
}
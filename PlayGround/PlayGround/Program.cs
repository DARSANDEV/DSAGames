using PlayGround;

Console.WriteLine("Welcome");

bool retry = false;
do
{
    try
    {
        var gameNames = Enum.GetValues(typeof(GameNames));

        Console.WriteLine("************* Choose a Game *******************");
        foreach (var item in gameNames)
        {
            Console.WriteLine($"{(int)item} : {item}");
        }
        int chosenGameNum;
        int.TryParse(Console.ReadLine(), out chosenGameNum);
        GameNames chosenGame = (GameNames)chosenGameNum;
        Game game = chosenGame.CreateGame();
        game.GameDescription();
        Console.WriteLine($"************* Starts {chosenGame} *******************");

        game.StartGame();
        Console.WriteLine("--------------- Game completed -------------------");

    }
    catch (Exception ex)
    {
        Console.WriteLine("Some error occured : {0}", ex);
    }
    Console.WriteLine(" Press 1 to try again ");
    var retryInput = int.Parse(Console.ReadLine());
    retry = (retryInput == 1) ? true : false;

} while (retry);
Console.WriteLine("Thank you for Playing");



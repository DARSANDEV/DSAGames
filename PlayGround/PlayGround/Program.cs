using PlayGround;

Console.WriteLine("Welcome");

bool retry = false;
do
{
    var gameNames = Enum.GetValues(typeof(GameNames));
    
    Console.WriteLine("************* Choose a Game *******************");
    foreach (var item in gameNames)
    {
        Console.WriteLine($"{(int)item} : {item}");
    }
    int chosenGameNum;
    int.TryParse(Console.ReadLine(),out chosenGameNum);
    GameNames chosenGame = (GameNames) chosenGameNum;

    //var sampleObj = new SampleObject();
    Game game = chosenGame.CreateGame();
    game.GameDescription();
    Console.WriteLine($"************* Starts {chosenGame} *******************");

    game.StartGame();
    Console.WriteLine("--------------- Game completed -------------------");
    Console.WriteLine(" Press 1 to try again ");
    var  retryInput= int.Parse(Console.ReadLine());
    retry = (retryInput ==1) ? true : false;
} while (retry );


 
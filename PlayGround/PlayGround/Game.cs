
namespace PlayGround
{
    public abstract class Game
    {
       public abstract void StartGame();

       public virtual void GameDescription(){
        Console.WriteLine("No Description Available for this game");
       }
    }

}

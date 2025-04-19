using PlayGround;
namespace PlayGround.Games;
public class Hcf : Game
{
    public override void StartGame()
    {
         System.Console.WriteLine("Enter the first number");
         int a = int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter the Second number");
         int b = int.Parse(Console.ReadLine());
         var hcf = HcfRec(a,b);
         Console.WriteLine($"the HCF of {a}, {b} is {hcf}");
    }
    private int HcfRec(int a, int b){
        if( b==0){
            return a;
        }
        return HcfRec(b, a%b);
    }
}
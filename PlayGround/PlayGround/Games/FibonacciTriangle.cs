using PlayGround;
namespace PlayGround.Games;
public class FibonacciTriangle : Game
{
    public override void StartGame()
    {
         System.Console.WriteLine( "Starting Triangle");
         System.Console.WriteLine("Enter a number");
         int num = int.Parse(Console.ReadLine());
         FibTriangle(num);
         //FibSeries(num);

    }

    private void FibTriangle(int num){
        long a=0, b= 1, c=0;

        for (int i =1 ; i<= num; i++)
        {
            //Console.Write("{0}\t",b);
            for (int j =1; j<=i; j++)
            {
                Console.Write("{0} \t",b);
                c= a+b;
                //Console.Write("{0} \t",c);
                a= b;
                b=c;
            }
            Console.Write("\n");
        }
    }

    // Print fibinaci series number
    private void FibSeries(int num){
        long a=0, b= 1, c=0;

        for (int i =1 ; i<= num; i++){
          
                c= a+b;
                Console.Write("{0} \t",c);
                a= b;
                b=c;
            
        }
    }

}
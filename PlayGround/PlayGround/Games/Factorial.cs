namespace PlayGround.Games
{
    public class Factorial : Game
    {
        public  override void StartGame()
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            var output = Fact(n);
            Console.WriteLine($"The factorial is {output}");
        } 

        private static int Fact(int num)
        {
            if (num ==0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * Fact(num - 1);
            }
        }
    }
}

using PlayGround;
using PlayGround.Games;

public static class GameFactory {

    public static Game CreateGame( this GameNames gameName    ){
        return gameName switch {
            GameNames.FindFactorial => new Factorial (),
            GameNames.Palindrome => new Palindrome(),
            GameNames.MergeSort=> new MergeSort(),
            GameNames.SuperReducedString=> new SuperReducedString(),
            GameNames.FibonacciTriangle => new FibonacciTriangle(),
            GameNames.Hcf => new Hcf(),
            _ => throw new ArgumentException($"Invalid game type {gameName}")
        };
    }
}
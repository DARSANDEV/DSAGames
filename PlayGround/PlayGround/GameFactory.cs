using PlayGround;
using PlayGround.Games;

public static class GameFactory {

    public static Game CreateGame( this GameNames gameName    ){
        return gameName switch {
            GameNames.FindFactorial => new Factorial (),
            _ => throw new ArgumentException("Invalid game type")
        };
    }
}
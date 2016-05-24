class Program
{
    static void Main(string[] args)
    {
        var player = new Player();
        player.Name = "Eric";

        var game = new Hangman();

        game.Player = player;

        game.Guess('a');
    }
}
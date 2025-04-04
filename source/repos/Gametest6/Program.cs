using System;

namespace GameTest6 // Ensure this matches the namespace in Game1.cs
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new HangmanGame()) // Instantiate the HangmanGame class
            {
                game.Run(); // Start the game
            }
        }
    }
}

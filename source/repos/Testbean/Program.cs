using System;

namespace RPGMovement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classic RPG Movement System");
            Console.WriteLine("Use 'w' to move up, 's' to move down, 'a' to move left, and 'd' to move right.");
            Console.WriteLine("Type 'exit' to quit.");

            // Initialize grid and character
            Grid grid = new Grid(10, 10);
            Character character = new Character(5, 5);

            while (true)
            {
                grid.Draw(character);
                Console.Write("Enter direction: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (input.Length == 1)
                {
                    char direction = input[0];
                    character.Move(direction);

                    if (!grid.IsValidPosition(character.X, character.Y))
                    {
                        // Revert move if out of bounds
                        character.Move(OppositeDirection(direction));
                        Console.WriteLine("Out of bounds! Move reverted.");
                    }

                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please enter a single character for direction.");
                }
            }

            Console.WriteLine("Exiting the Classic RPG Movement System.");
        }

        static char OppositeDirection(char direction)
        {
            switch (direction)
            {
                case 'w': return 's';
                case 's': return 'w';
                case 'a': return 'd';
                case 'd': return 'a';
                default: return ' ';
            }
        }
    }
}

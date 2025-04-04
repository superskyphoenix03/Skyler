using System;

namespace RPGMovement
{
    class Character
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Character(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(char direction)
        {
            switch (direction)
            {
                case 'w': // Move up
                    Y--;
                    break;
                case 's': // Move down
                    Y++;
                    break;
                case 'a': // Move left
                    X--;
                    break;
                case 'd': // Move right
                    X++;
                    break;
                default:
                    Console.WriteLine("Invalid direction!");
                    break;
            }
        }

        public void DisplayPosition()
        {
            Console.WriteLine($"Character is at position: ({X}, {Y})");
        }
    }

    class Grid
    {
        private readonly int _width;
        private readonly int _height;

        public Grid(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < _width && y >= 0 && y < _height;
        }

        public void Draw(Character character)
        {
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    if (x == character.X && y == character.Y)
                    {
                        Console.Write("C ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


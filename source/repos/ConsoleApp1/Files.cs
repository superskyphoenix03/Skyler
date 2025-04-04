using System;

namespace Project1 // Sets up the namespace
{
    class Project1 // Sets up the main class
    {
        static void Main(string[] args) // The main events for the program are here
        {
            AskForNameAndAge();
        }

        static void AskForNameAndAge()
        {
            // Ask for name
            SetConsoleColor(ConsoleColor.White);
            Console.WriteLine("What's your name?");
            SetConsoleColor(ConsoleColor.Blue);
            string name = Console.ReadLine();
            SetConsoleColor(ConsoleColor.White);

            if (string.IsNullOrEmpty(name))
            {
                HandleEmptyName();
            }
            else
            {
                GreetUser(name);
                AskForAge(name);
            }
        }

        static void SetConsoleColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        static void HandleEmptyName()
        {
            SetConsoleColor(ConsoleColor.Red);
            Console.WriteLine("You didn't enter a name");
            Console.Beep();
            SetConsoleColor(ConsoleColor.White);
        }

        static void GreetUser(string name)
        {
            SetConsoleColor(ConsoleColor.Green);
            Console.Write("Hello, ");
            SetConsoleColor(ConsoleColor.White);
            Console.Write(name);
            SetConsoleColor(ConsoleColor.Green);
            Console.WriteLine("! It is a pleasure to meet you.");
            SetConsoleColor(ConsoleColor.White);
        }

        static void AskForAge(string name)
        {
            SetConsoleColor(ConsoleColor.White);
            Console.WriteLine("What's your age?");
            SetConsoleColor(ConsoleColor.Blue);
            string ageInput = Console.ReadLine();
            SetConsoleColor(ConsoleColor.White);

            if (int.TryParse(ageInput, out int age))
            {
                RespondWithAge(name, age);
            }
            else
            {
                HandleInvalidAge();
            }
        }

        static void RespondWithAge(string name, int age)
        {
            SetConsoleColor(ConsoleColor.Green);
            Console.Write("I see, so you are ");
            SetConsoleColor(ConsoleColor.White);
            Console.Write(age);
            SetConsoleColor(ConsoleColor.Green);
            Console.Write(" years old, ");
            SetConsoleColor(ConsoleColor.White);
            Console.Write(name);
            SetConsoleColor(ConsoleColor.Green);
            Console.WriteLine("?");
        }

        static void HandleInvalidAge()
        {
            SetConsoleColor(ConsoleColor.Red);
            Console.WriteLine("Not a Number");
            Console.Beep();
            SetConsoleColor(ConsoleColor.White);
        }
    }
}

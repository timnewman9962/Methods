using System;

namespace Methods
{
    class Program
    {
        public static string PromptQandA(string prompt)
        {
            Console.WriteLine("\n" + prompt);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\nLet's make a story...");
            string name = PromptQandA("So what's your name?");
            string city = PromptQandA("And what is your favorite city?");
            string food = PromptQandA("What do you like to eat there?");
            string movie = PromptQandA("What is your all-time favorite movie?");

            Console.WriteLine($"\nlet me get this stright, {name}...\n" +
                $"you'll eat {food},\n" +
                $"you've been to {city},\n" +
                $"and you've seen {movie}.\n"
                );

            Console.WriteLine($"Here's the story: In downtown {city}, " +
                $"in a movie theatre where \"{movie}\" was being played, " +
                $"customer {name} was asked to leave for eating {food}!!!");
        }
    }
}

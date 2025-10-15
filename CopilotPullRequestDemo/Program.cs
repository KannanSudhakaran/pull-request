using System;

namespace CopilotPullRequestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine() ?? string.Empty;
            GreetUser(name);
        }
        static void GreetUser(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Guest";
            }
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
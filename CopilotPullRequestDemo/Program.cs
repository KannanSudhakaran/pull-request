using System;

namespace CopilotPullRequestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            GreetUser(name);
        }
        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
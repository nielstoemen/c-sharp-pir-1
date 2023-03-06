using System;

namespace c_Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 1-1:");
            Console.WriteLine();
            Console.WriteLine("Hello world");
            Console.WriteLine();

            Console.WriteLine("Opdracht 1-2:");
            Console.WriteLine();
            Console.WriteLine("'Once upon a time'");
            Console.WriteLine("'I was falling in love'");
            Console.WriteLine("'Now I’m only falling apart'");
            Console.WriteLine();

            Console.WriteLine("Opdracht 1-3:");
            Console.WriteLine("Once upon a time\r\nI was falling in love\r\nNow I’m only falling apart");
            Console.WriteLine();

            Console.WriteLine("Opdracht 1-4:");
            string message = "Passport and a toothbrush!";
            Console.WriteLine(message);
            Console.WriteLine();

            Console.WriteLine("Opdracht 1-5:");
            string name = "Ada Lovelace";
            Console.WriteLine("hello " + name);
            Console.WriteLine();

            Console.WriteLine("Opdracht 1-6:");
            Console.WriteLine("User input:");
            var input = Console.ReadLine();
            Console.WriteLine("input: " + input);
            Console.WriteLine();

            Console.WriteLine("Opdracht 1-7:");
            Console.WriteLine("User input:");
            var secondInput = Console.ReadLine();
            Console.WriteLine(secondInput);
            Console.WriteLine(secondInput);
            Console.WriteLine(secondInput);
            Console.WriteLine();

            Console.WriteLine("Opdracht 1-8:");
            Console.WriteLine("Hello, what is your name?:");
            var thirdInput = Console.ReadLine();
            Console.WriteLine("hello: " + thirdInput + "!");
            Console.WriteLine();

            Console.WriteLine("Opdracht 1-9:");
            Console.WriteLine("Hello, how are you?:");
            var fourthInput = Console.ReadLine();
            Console.WriteLine("tell me more:");
            var fifthInput = Console.ReadLine();
            Console.WriteLine("Thank you for sharing");
            Console.WriteLine();

            Console.WriteLine("Opdracht 1-10:");
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            var sixtInput = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            var seventInput = Console.ReadLine();
            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a " + seventInput + " called " + sixtInput);
            Console.WriteLine("On their way to work, " + sixtInput + " often pondered what being " + seventInput + " meant to them.");
            Console.WriteLine("When you work as a " + seventInput + " you meet interesting people.");
            Console.WriteLine(sixtInput + " enjoys their work as " + seventInput + ", The end.");
            Console.WriteLine();


        }
    }
}
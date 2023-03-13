using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace week3_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercise 3.24");
            string userName1 = "alex";
            string userName2 = "emma";
            string password1 = "sunshine";
            string password2 = "haskell";
            Console.WriteLine("Username:");
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();
            if (userInput1 == userName1) 
            { 
                if (userInput2 == password1) 
                { 
                    Console.WriteLine("sucsesfully logged in");
                }
                else
                {
                    Console.WriteLine("incorrect username or password");
                }
            }
            else if(userInput1 == userName2) 
            { 
                if (userInput2 == password2) 
                {
                    Console.WriteLine("sucsesfully logged in");
                }
                else
                {
                    Console.WriteLine("incorrect username or password");
                }
            }
            else
            {
                Console.WriteLine("incorrect username or password");
            }

            
            Console.WriteLine(" ");

            Console.WriteLine("exercise 3.28:");
            string userInput3 = Console.ReadLine();
            string[] pieces = userInput3.Split(" ");
            string lastOne = pieces.Last();
            Console.WriteLine(lastOne);
            Console.WriteLine(" ");

            Console.WriteLine("exercise 3.29:");
            int highestAge = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] pieces1 = input.Split(",");
                Console.WriteLine("Name: " + pieces1[0] + ", age: " + pieces1[1]);
                
                int test = Convert.ToInt32(pieces1[1]);
                if (test > highestAge)
                { 
                    highestAge = test;
                }
                Console.WriteLine("higherst age untill now:" + highestAge);
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 3.30:");
            int highestAge1 = 0;
            string highestName = "kut";
            while (true)
            {
                string input1 = Console.ReadLine();
                if (input1 == "")
                {
                    break;
                }
                string[] pieces2 = input1.Split(",");
                Console.WriteLine("Name: " + pieces2[0] + ", age: " + pieces2[1]);

                int test = Convert.ToInt32(pieces2[1]);
                if (test > highestAge1)
                {
                    highestAge1 = test;
                    highestName = pieces2[0];
                }
                Console.WriteLine("higherst name with age untill now:" + highestName);
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 3.31:");
            int highestAge2 = 0;
            string highestName1 = "kut";
            int currentYear = 2023;
            while (true)
            {
                string input2 = Console.ReadLine();
                if (input2 == "")
                {
                    break;
                }
                string[] pieces3 = input2.Split(",");
                Console.WriteLine("Name: " + pieces3[0] + ", age: " + pieces3[1]);

                int age = currentYear - Convert.ToInt32(pieces3[1]);

                if (age > highestAge2)
                {
                    highestAge2 = age;
                    highestName1 = pieces3[0];
                }
                Console.WriteLine("higherst name with age untill now:" + highestName1);
                Console.WriteLine("higherst age untill now:" + highestAge2);
            }
            Console.WriteLine(" ");




        }
    }
}
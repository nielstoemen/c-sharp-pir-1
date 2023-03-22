using System.ComponentModel.Design;
using System.IO;

namespace week4_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercise 4.3:");
            Console.WriteLine("zie dog.cs");
            Console.WriteLine(" ");

            Console.WriteLine("exercise 4.4:");
            Console.WriteLine("zie room.cs");
            Console.WriteLine(" ");

            Console.WriteLine("exercise 4.21:");
            List<book> books = new List<book>();
            while (true) 
            {
                Console.Write("Enter a name, empty will stop: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                Console.Write("enter amount of pages");
                int pages = Convert.ToInt32(Console.ReadLine());

                Console.Write("what year did it come out:");
                int year = Convert.ToInt32(Console.ReadLine());

                books.Add(new book (name, pages, year));
            }

            Console.WriteLine(books.Count);

            foreach (book booking in books) 
            { 
                Console.WriteLine(booking);
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 4.22:");
            int teller = 0;
            while (true) 
            { 
                Console.WriteLine("input:");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine("amount of words you wrote:" + teller);
                    break;
                }
                else
                {
                    Console.WriteLine(input);
                    teller++;
                }
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 4.23:");
            int teller1 = 0;
            while (true)
            {
                Console.WriteLine("input:");
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine("amount of numbers you wrote:" + teller1);
                    break;
                }
                else
                {
                    int convert = Convert.ToInt32(input);
                    int math = convert * convert * convert;
                    Console.WriteLine(math);
                    teller1++;
                }
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 4.24:");
            string text = File.ReadAllText("data.txt");
            Console.WriteLine(text);
            Console.WriteLine(" ");


            Console.WriteLine("exercise 4.26");
            string[] list = File.ReadAllLines("names.txt");
            string[] otherList = File.ReadAllLines("other-names.txt");
            List<Person> persons = new List<Person>();

            foreach (string line in list)
            {
                string[] pieces = line.Split(",");
                string name = pieces[0];

                persons.Add(new Person(name));
            }

            foreach (string line in otherList)
            {
                string[] pieces = line.Split(",");
                string name = pieces[0];

                persons.Add(new Person(name));
            }

            foreach(var line in persons)
            {
                string[] test = line.name.Split(" ");
                Console.WriteLine(test);
            }







        }
    }
}
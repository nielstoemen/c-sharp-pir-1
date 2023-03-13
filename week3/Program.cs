namespace C__project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercise 2.1");
            int user1 = Convert.ToInt32(Console.ReadLine());
            int uitkomst = user1 * user1;
            Console.WriteLine(uitkomst);
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.2");
            Console.WriteLine("int:");
            int user2 = Convert.ToInt32(Console.ReadLine());
            double uitkomst2 = Math.Sqrt(user2);
            Console.WriteLine(uitkomst2);
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.3");
            Console.WriteLine("int:");
            int user3 = Convert.ToInt32(Console.ReadLine());
            var uitkomst3 = user3 * -1;
            if (user3 < 0) 
            {
                Console.WriteLine(uitkomst3);
            }
            else
            {
                Console.WriteLine(user3);
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.4");
            Console.WriteLine("nummer 1:");
            int nummer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nummer 2:");
            int nummer2 = Convert.ToInt32(Console.ReadLine());
            if (nummer1 < nummer2)
            {
                Console.WriteLine(nummer1 + " is kleiner dan " + nummer2);
            }else if (nummer1 > nummer2) 
            {
                Console.WriteLine(nummer1 + " is groter dan " + nummer2);
            }
            else 
            {
                Console.WriteLine(nummer1 + " is gelijk aan " + nummer2);
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.5");
            Console.WriteLine("nummer:");
            int input4 = Convert.ToInt32(Console.ReadLine());
            int nummer = 1;
            while (nummer <= input4) 
            { 
                Console.WriteLine(nummer);
                nummer++;
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.6");
            Console.WriteLine("nummer:");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int nummer3 = 1;
            while (nummer3 <= 100)
            {
                Console.WriteLine(nummer3);
                //Thread.Sleep(100);
                nummer3++;
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.7");
            Console.WriteLine("were to:");
            int input6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("were from:");
            int input7 = Convert.ToInt32(Console.ReadLine());
            int nummer4 = input7;
            while (nummer4 <= input6)
            {
                Console.WriteLine(nummer4);
                //Thread.Sleep(100);
                nummer4++;
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.8");
            int neededNumber = -1;
            bool givenNumber = false;
            int numbers = 0;
            while (givenNumber == false) 
            {


                Console.WriteLine("Number?:");
                int userInput1 = Convert.ToInt32(Console.ReadLine());

                if (userInput1 == neededNumber)
                {
                    givenNumber = true;
                    Console.WriteLine("thx, bye!");
                    Console.WriteLine("numbers:" + numbers);
                }
                else
                {
                    numbers++;
                }
            }


            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.9");
            PrintPhrase();
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.10");
            Console.WriteLine("how many times?:");
            int input8 = Convert.ToInt32(Console.ReadLine());
            int number9 = 1;
            while (number9 <= input8)
            {
                PrintPhrase();
                number9++;
            }
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.11");
            PrintUntilNumber(5);
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.12");
            PrintFromNumberToOne(5);
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.13");
            Console.WriteLine("niet begrijpen, vragen aan docent aankomende les");
            Console.WriteLine(" ");

            Console.WriteLine("exercise 2.14");
            Console.WriteLine("niet begrijpen, vragen aan docent aankomende les");
            Console.WriteLine(" ");





        }

        public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method.");
        }

        public static void PrintUntilNumber(int v)
        {
            int nummer4 = 1;
            while (nummer4 <= v)
            {
                Console.WriteLine(nummer4);
                nummer4++;
            }
        }

        public static void PrintFromNumberToOne(int a)
        {
            int nummer5 = a;
            while(nummer5 >= 1)
            {
                Console.WriteLine(nummer5);
                nummer5--;
            }
        }



    }
}
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









        }
    }
}
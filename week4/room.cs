namespace week4_c_sharp;

public class room
{
    private string code;
    private int seats;

    

    public room(string code, int seats)
    {
        Console.WriteLine("classroom name:");
        code = Console.ReadLine();
        Console.WriteLine("amount of seats:");
        seats = Convert.ToInt32(Console.ReadLine());
    }
}


namespace week4_c_sharp;

public class book
{

    public string name { get; }
    public int pages { get; set; }
    public int year { get; set; }

    public book(string name, int pages, int year)
    {
        this.name = name;
        this.pages = pages;
        this.year = year;
    }

}

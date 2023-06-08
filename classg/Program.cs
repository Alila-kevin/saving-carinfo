internal class Program
{
    private static void Main(string[] args)
    {
        car mycarinfo = new car();

        Console.WriteLine("please your car information as below instraction!!!");
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("input your car make");
        string? m = Console.ReadLine();
        mycarinfo.make = m;
        Console.WriteLine("input your car model");
        string? q = Console.ReadLine();
        mycarinfo.model = q;
        Console.WriteLine("inpu the year of the release");
        mycarinfo.year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Below car information below is for your car as your have provided");
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine($"car make: {mycarinfo.make} ");
        Console.WriteLine($"car model; {mycarinfo.model}");
        Console.WriteLine($"Year: {mycarinfo.year}");
       mycarinfo.starcar();
        mycarinfo.drive();
    }
}

public class car
{
    public string model;
    public string make;
    public int year;

    public void starcar()
    {
        Console.WriteLine("Engine started ");
    }
    public void drive()
    {
        Console.WriteLine("car moving");
    }
}
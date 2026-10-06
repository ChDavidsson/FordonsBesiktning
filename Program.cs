namespace FordonsBesiktning;

class Program
{
    static void Main(string[] args)
    {
        Fordon fordon1 = new Fordon();
        Console.WriteLine("Vilken årsmodell är fordonet?");
        fordon1.Year = int.Parse(Console.ReadLine());
        Console.WriteLine("Har fordonet försäkring? (ja/nej)");
        fordon1.HasInsurance = Console.ReadLine().ToLower() == "ja";
        Console.WriteLine(fordon1.CheckInspection());
    }
}

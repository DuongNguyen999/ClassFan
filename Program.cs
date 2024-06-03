public class Program
{
    public static void Main(string[] args)
    {
        // Create first fan object
        Fan fan1 = new Fan
        {
            Speed = Fan.FAST,
            Radius = 10,
            Color = "yellow",
            On = true
        };

        // Create second fan object
        Fan fan2 = new Fan
        {
            Speed = Fan.MEDIUM,
            Radius = 5,
            Color = "blue",
            On = false
        };

        // Display the fans
        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString());
    }
}
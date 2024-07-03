using DiamondGenerator;

class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a character (A-Z): ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line

            var diamond = new Diamond();
            Console.WriteLine(diamond.Create(inputChar));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
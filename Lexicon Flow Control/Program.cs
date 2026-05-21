namespace Lexicon_Flow_Control;

class Program
{
    static void Main(string[] args)
    {
        try
        {

            bool programRunning = true;
            while (programRunning)
            {
                Console.WriteLine("Hello, enter number to test different functions!");
                Console.WriteLine("0. Exit the program");
                string input = Console.ReadLine() ?? string.Empty;
                switch (input)
                {
                    case "0":
                        programRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
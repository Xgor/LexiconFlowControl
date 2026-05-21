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
                Console.WriteLine("1. Add to Cinema Group");
                Console.WriteLine("2. Calculate cost for Cinema Group");
                Console.WriteLine("3. Repeat line 10 times");
                Console.WriteLine("4. Find Third word in line");
                string input = Console.ReadLine() ?? string.Empty;
                switch (input)
                {
                    case "0":
                        programRunning = false;
                        break;
                    case "1":
                        AddToCinemaGroup();
                        break;
                    case "2":
                        CalculateCinemaGroupPrice();
                        break;
                    case "3":
                        Repeat10();
                        break;
                    case "4":
                        GetThirdWord();
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

    static void AddToCinemaGroup()         // TODO
    {

    }
    
    static void CalculateCinemaGroupPrice()        // TODO
    {

    }
    
    static void Repeat10()
    {
        Console.WriteLine("Write text to repeat 10 times");
        string l = Console.ReadLine() ?? string.Empty;
        ConsoleRepeater.RepeatStringXTimes(l, 10);
    }
    
    static void GetThirdWord()
    {
        Console.WriteLine("Write a sentence and I'll find the third word");
        string l = Console.ReadLine() ?? string.Empty;
        string thirdWord = l.GetThirdWord() ?? string.Empty;
        Console.WriteLine(thirdWord != string.Empty
            ? $"""The Third Word is "{thirdWord}"!"""
            : "Couldn't find the third word.");
    }
}


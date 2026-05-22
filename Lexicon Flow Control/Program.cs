namespace Lexicon_Flow_Control;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Hello, enter number to test different functions!");
            bool programRunning = true;
            while (programRunning)
            {
                
                Console.WriteLine("0. Exit the program 1. Add to Cinema Group 2. Calculate cost for Cinema Group " +
                                  "3. Repeat line 10 times 4. Find Third word in line");

                string input = Console.ReadLine() ?? string.Empty;
                switch (input)
                {
                    case "0":
                        programRunning = false;
                        break;
                    case "1":
                        CalculateCinemaPrice();
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

    static void CalculateCinemaPrice() 
    {
        Console.WriteLine("What age is the person buying the ticket");
        string input = Console.ReadLine() ?? string.Empty;
        Console.WriteLine(Cinema.GetCinemaPriceText(input));
    }
    
    static void CalculateCinemaGroupPrice()
    {
        Console.WriteLine("How many are in the group");
        string groupSizeInput = Console.ReadLine() ?? string.Empty;
        int totalPrice = 0;
        if (int.TryParse(groupSizeInput, out int groupsize) && groupsize > 0)
        {
            for (int i = 0; i < groupsize; i++)
            {
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Faulty input");
                }

                totalPrice += Cinema.GetCinemaPrice(age);
            }
        }
        else
        {
            Console.WriteLine("Not a valid group size"); // Currently goes back, maybe should loop instead
        }

        Console.WriteLine($"Total group price {totalPrice}");
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


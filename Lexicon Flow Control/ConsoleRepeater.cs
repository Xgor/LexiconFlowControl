namespace Lexicon_Flow_Control;

public static class ConsoleRepeater
{
    public static void RepeatStringXTimes(string str,int repeatTimes)
    {
        for (int i = 0; i < repeatTimes; i++)
        {
            Console.Write($"{i + 1}. {str}, ");
        }
        Console.WriteLine(); // Line break for new line
    }
}
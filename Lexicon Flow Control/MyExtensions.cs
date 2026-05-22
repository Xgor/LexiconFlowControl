namespace Lexicon_Flow_Control;

public static class MyExtensions
{
    extension(string str)
    {
        // returns null if third word can't be returned
        public string? GetThirdWord()
        {
            string[] s = str.Split();
            return s.Length > 2 ? s[2] : null;
        }

    }
}
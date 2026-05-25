
namespace Lexicon_Flow_Control;




public class Cinema
{
    const int PRICE_SENIOR = 90;
    const int PRICE_JUNIOR = 80;
    const int PRICE_STANDARD = 120;

    private const int AGE_SENIOR = 64;
    private const int AGE_ADULT = 20;
    private const string CURRENCY = "kr";

    static public string GetCinemaPriceText(string age)
    {
        int price = GetCinemaPrice(age);
        string priceType = price switch
        {
            PRICE_JUNIOR => priceType = "Ungdomspris",
            PRICE_STANDARD => priceType = "Standardpris",
            PRICE_SENIOR => priceType = "Pensionärspris",
            _ => throw new ArgumentOutOfRangeException(nameof(price), $"Not defined price type: {price}"),
        };

        return $"{priceType}: {price}{CURRENCY}";
    }
    static public int GetCinemaPrice(string age)
    {
        return GetCinemaPrice(int.TryParse(age,out int i) ? i : -1);
    }
    static public int GetCinemaPrice(int age)
    {
        return age switch
        {
            < 0 => throw new ArgumentOutOfRangeException(),
            < AGE_ADULT => PRICE_JUNIOR,
            > AGE_SENIOR => PRICE_SENIOR,
            _ => PRICE_STANDARD
        };
    }
}
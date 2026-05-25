using Lexicon_Flow_Control;

namespace TestProject;

public class CinemaTest
{
    [Test]
    public void JuniorCost()
    {
        Assert.That(Cinema.GetCinemaPrice(5)==80);
        Assert.That(Cinema.GetCinemaPrice(19)==80);
    }
    
    [Test]
    public void AdultCost()
    {
        Assert.That(Cinema.GetCinemaPrice(20)==120);
        Assert.That(Cinema.GetCinemaPrice(64)==120);
        
    }
    [Test]
    
    public void SeniorCostTest()
    {
        Assert.That(Cinema.GetCinemaPrice(65) == 90);
        Assert.That(Cinema.GetCinemaPrice(100)==90);
    }

    public void FreeEntranceTest()
    {
        Assert.That(Cinema.GetCinemaPrice(5) == 0);
        Assert.That(Cinema.GetCinemaPrice(101) == 0);
    }
    
    [Test]
    public void InvalidAgeTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(()=>Cinema.GetCinemaPrice(-1));
    }
    
    [Test]
    public void JuniorCostTextTest()
    {
        Assert.That(Cinema.GetCinemaPriceText("6")=="Ungdomspris: 80kr");
    }
    
    [Test]
    public void AdultCostTextTest()
    {
        Assert.That(Cinema.GetCinemaPriceText("43")=="Standardpris: 120kr");
    }
    
    [Test]
    public void SeniorCostTextTest()
    {
        Assert.That(Cinema.GetCinemaPriceText("66")=="Pensionärspris: 90kr");
    }
    
    [Test]
    public void FreeTextTest()
    {
        Assert.That(Cinema.GetCinemaPriceText("3")=="Gratis Inträde: 0kr");
    }
    
    [Test]
    public void InvalidAgeNameTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(()=>Cinema.GetCinemaPrice("no"));
    }
    
}
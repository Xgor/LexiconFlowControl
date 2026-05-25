using Lexicon_Flow_Control;

namespace TestProject;

public class CinemaTest
{
    [Test]
    public void JuniorCost()
    {
        Assert.That(Cinema.GetCinemaPrice(1)==80);
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
        Assert.That(Cinema.GetCinemaPrice(120)==90);
    }

    [Test]
    public void InvalidAgeTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(()=>Cinema.GetCinemaPrice(-1));
    }
    
    [Test]
    public void JuniorCostNameTest()
    {
        Assert.That(Cinema.GetCinemaPriceText("1")=="Ungdomspris: 80kr");
    }
    
    [Test]
    public void AdultCostNameTest()
    {
        Assert.That(Cinema.GetCinemaPriceText("43")=="Standardpris: 120kr");
    }
    [Test]
    public void SeniorCostNameTest()
    {
        Assert.That(Cinema.GetCinemaPriceText("66")=="Pensionärspris: 90kr");
        
    }
    
    
    [Test]
    public void InvalidAgeNameTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(()=>Cinema.GetCinemaPrice("no"));
    }
    
}
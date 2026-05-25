
using Lexicon_Flow_Control;
namespace TestProject;


public class ExtensionsTest
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void CanGetThirdWord()
    {
        string line = "has three words";

        Assert.That(line.GetThirdWord()=="words");
        
    }

    [Test]
    public void NoThirdWord()
    {
        string line = "two words";

        Assert.That(line.GetThirdWord() == null);
    }
}
using Lexicon_Flow_Control;

namespace TestProject;

public class ConsoleRepeaterTest
{
    [Test]
    public void CanRepeat()
    {
        ConsoleRepeater.RepeatStringXTimes("text",10);
        Assert.Pass();
    }
}
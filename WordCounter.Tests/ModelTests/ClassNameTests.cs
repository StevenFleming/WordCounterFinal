using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace Project.Tests
{
  [TestClass]
  public class RepeateWordCounterTests
  {
    [TestMethod]
    public void RepeatWordCounterConstructor_TakesAStringAsParameterAndReturnsItLowerCase_RepeatWordCounter()
    {
      RepeatWordCounter newCounter = new RepeatWordCounter("Hello", "Hello There");
      Assert.AreEqual(newCounter.Word, "hello");
    }

    // Test to check for Word input no longer vaild
    public void RepeatWordCounter_TakesSentenceAndMakesAnArray_SentenceCheckWord()
    {
      RepeatWordCounter newCounter = new RepeatWordCounter("Hello", "Hello There");
      Assert.AreEqual(newCounter.SentenceCheckWord(), "hello");
    }

    [TestMethod]
    public void RepeatWordCounter_ReturnsCountofMatchingWordsinSentence_SentenceCheckWord()
    {
      RepeatWordCounter newCounter = new RepeatWordCounter("Hello", "Hello There");
      Assert.AreEqual(newCounter.SentenceCheckWord(), 1);
    }

    [TestMethod]
    public void RepeatWordCounter_ChecksforNumbersinWords_WordCheckNumbers()
    {
      RepeatWordCounter newCounter = new RepeatWordCounter("Hel2lo1", "Hello There");
      Assert.AreEqual(newCounter.WordCheckNumbers(), false);
    }

    [TestMethod]
    public void RepeatWordCounter_ChecksforNumbersinSentences_SentenceCheckNumbers()
    {
      RepeatWordCounter newCounter = new RepeatWordCounter("Hello", "Hel3lo Th3ere");
      Assert.AreEqual(newCounter.SentenceCheckNumbers(), false);
    }

    [TestMethod]
    public void RepeatWordCounter_ChangesNumberProperty_CheckNumbs()
    {
      RepeatWordCounter newCounter = new RepeatWordCounter("Hello", "Hel3lo Th3ere");
      newCounter.CheckNums();
      Assert.AreEqual(newCounter.Numbers, false);
    }

    [TestMethod]
    public void RepeatWordCounter_ChangesCommasandPeriodsToBlanks_sentenceCommasandPeriods()
    {
      RepeatWordCounter newCounter = new RepeatWordCounter("Hello", "Hello, There");
      Assert.AreEqual(newCounter.sentenceCommasandPeriods(), 1);
    }
  }
}
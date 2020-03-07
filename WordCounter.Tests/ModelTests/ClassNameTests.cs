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

    [TestMethod]
    public void RepeatWordCounter_TakesSentenceAndMakesAnArray_RepeatWordCounter()
    {
      RepeatWordCounter newCounter = new RepeatWordCounter("Hello", "Hello There");
      Assert.AreEqual(newCounter.SentenceArrayCreator(), "hello");
    }

  }
}
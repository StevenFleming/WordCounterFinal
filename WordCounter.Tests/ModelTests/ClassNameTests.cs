using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace Project.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void RepeatWordCounterConstructor_TakesAStringAsParameterAndReturnsItLowerCase_RepeatCounter()
    {
      RepeatWordCounter newCounter = new RepeatWordCounter("Hello", "Hello There");
      Assert.AreEqual(newCounter.Word, "hello");
    }

  }
}
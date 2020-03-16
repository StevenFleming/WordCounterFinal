using System;
using WordCounter;

namespace Project
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Word Test");
      Console.WriteLine("Please input a sentance");
      string userSentence = Console.ReadLine();
      Console.WriteLine("Please input what word you would like to check");
      string userWord = Console.ReadLine();
      RepeatWordCounter newCounter = new RepeatWordCounter(userWord, userSentence);
      Console.WriteLine($"your word appears {newCounter.SentenceCheckWord()} times in your sentance");
    }
  }
}
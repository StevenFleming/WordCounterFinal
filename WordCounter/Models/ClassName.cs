using System;

namespace WordCounter
{
  public class RepeatWordCounter
  {

    public int MatchCount { get; set; }
    public string Word { get; set; }
    public string Sentence { get; set; }

    public bool Numbers { get; set; }


    //Constructor
    public RepeatWordCounter(string word, string sentence)
    {
      MatchCount = 0;
      Word = word.ToLower().Trim();
      Sentence = sentence.ToLower().Trim();
      Numbers = true;
    }

    public void CheckNums()
    {
      if (WordCheckNumbers() == false || SentenceCheckNumbers() == false)
      {
        Numbers = false;
      }
    }

    public bool WordCheckNumbers()
    {
      char[] wordchars = Word.ToCharArray();
      for (int i = 0; i < Word.Length; i++)
      {
        for (int b = 0; b < 10; b++)
        {
          if (wordchars[i].ToString() == b.ToString())
          {
            return false;
          }
        }
      }
      return true;
    }

    public bool SentenceCheckNumbers()
    {
      char[] wordchars = Sentence.ToCharArray();
      for (int i = 0; i < Sentence.Length; i++)
      {
        for (int b = 0; b < 10; b++)
        {
          if (wordchars[i].ToString() == b.ToString())
          {
            return false;
          }
        }
      }
      return true;
    }


    public int SentenceCheckWord()
    {
      string[] sentenceArray = Sentence.Split(' ');
      for (int i = 0; i < sentenceArray.Length; i++)
      {
        if (sentenceArray[i] == Word)
        {
          MatchCount++;
        }
      }
      return MatchCount;
    }
    // Unfinished code 
    // public int sentenceCommasandPeriods()
    // {
    //   int CountTest = 0;
    //   string[] sentenceArray = Sentence.Split();
    //   for (int i = 0; i < sentenceArray.Length; i++)
    //   {
    //     if (sentenceArray[i] == "," || sentenceArray[i] == ".")
    //     {
    //       CountTest++;
    //     }
    //   }
    //   return sentenceArray.Length;
    // }
  }
}




// char[] checkNumArray = userWord.ToCharArray("a");
// return checkNumArray[0];

//   for (int i = 0; i < checkNumArray.Length; i++)
//   {
//     for (int b = 0; b < numberArray.Length; b++)
//     {
//       if (CheckNumArray[i] == numberArray[b])
//       {
//         return false;
//       }
//     }
//   }
//   return true;
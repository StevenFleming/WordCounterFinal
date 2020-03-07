using System;

namespace WordCounter
{
  public class RepeatWordCounter
  {

    public int MatchCount { get; set; }
    public string Word { get; set; }
    public string Sentence { get; set; }

    //Constructor
    public RepeatWordCounter(string word, string sentence)
    {
      MatchCount = 0;
      Word = word.ToLower();
      Sentence = sentence.ToLower();
    }

    public bool WordCheckNumbers()
    {

    }

    // public bool WordCheckOtherExpressions()
    // {

    // }

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
  }
}




// char[] numberArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
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
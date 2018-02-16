using System;
using System.Collections.Generic;

namespace ScrabbleProject.Models
{
  public class Scrabble
  {

    public static int counter = 0;

    public static int reset()
    {
      return counter = 0;
    }

    public int ScrabbleCalc(string word)
    {
      string userWord = word.ToUpper();

      var charsArray = userWord.ToCharArray();

      Dictionary<char, int> scrabbleLetters = new Dictionary<char, int>()
      {
        {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1},
        {'R', 1},{'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3},
        {'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4},
        {'K', 5}, {'J', 8}, {'Q', 10}, {'X', 8}, {'Z', 10}
      };

      foreach(char letter in charsArray)
      {
        counter += scrabbleLetters[letter];
        Console.WriteLine(letter);
      }

      return counter;
    }

  }
}

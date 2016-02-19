using System.Collections.Generic;
using System;

namespace RepeatCounterProject.Objects
{
  public class RepeatCounter
  {
    private string _searchTerm;
    private string _textBlock;


    public RepeatCounter(string searchTerm, string textBlock)
    {
      _searchTerm = searchTerm;
      _textBlock = textBlock;
    }


    public int CountRepeats()
    {
      int counter = 0;
      string searchTerm = _searchTerm.ToLower();
      string textBlock = _textBlock.ToLower();
      char[] specialCharacters =
      {
        '!', '@', '#', '$', '%', '^', '&',
        '*', '(', ')', '_', '-', '+', '=',
        '{', '}', '[', ']', '\\', '|', ':',
        ';', '\'', '\"', '<', '>', ',', '.',
        '?', '/'
      };
      string[] blockArray = textBlock.Split();
      foreach (string word in blockArray)
      {
        if (word.Trim(specialCharacters) == searchTerm)
        {
          counter++;
        }
        else
        {
          string[] subArray = word.Split(specialCharacters);
          foreach (string subWord in subArray)
          {
            if (subWord.Trim(specialCharacters) == searchTerm)
            {
              counter++;
            }
          }
        }
      }

      return counter;
    }
  }
}

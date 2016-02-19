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
      string[] blockArray = _textBlock.Split();

      foreach (string word in blockArray)
      {
        if (word == _searchTerm)
        {
          counter++;
        }
      }

      return counter;
    }
  }
}

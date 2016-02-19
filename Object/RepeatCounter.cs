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
      string[] blockArray = textBlock.Split();

      foreach (string word in blockArray)
      {
        if (word == searchTerm)
        {
          counter++;
        }
      }

      return counter;
    }
  }
}

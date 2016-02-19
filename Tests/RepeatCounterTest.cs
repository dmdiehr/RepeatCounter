using System.Collections.Generic;
using Xunit;
namespace RepeatCounterProject.Objects
{
  public class RepeatCounterTest
  {
    [Fact] //1
    public void CountRepeats_test_0()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "");
      Assert.Equal(newRepeatCounter.CountRepeats(), 0);
    }
    [Fact] //2
    public void CountRepeats_testtest_1()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "test");
      Assert.Equal(newRepeatCounter.CountRepeats(), 1);
    }
    [Fact] //3
    public void CountRepeats_testtestthistest_2()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "test this test");
      Assert.Equal(newRepeatCounter.CountRepeats(), 2);
    }
    [Fact] //4
    public void CountRepeats_Testtestthistest_2()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("Test", "test this test");
      Assert.Equal(newRepeatCounter.CountRepeats(), 2);
    }
    [Fact] //5
    public void CountRepeats_testTestthistest_2()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "Test this test");
      Assert.Equal(newRepeatCounter.CountRepeats(), 2);
    }
    [Fact] //6
    public void CountRepeats_testdontgettesty_0()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "Don't get testy");
      Assert.Equal(newRepeatCounter.CountRepeats(), 0);
    }
    [Fact] //7
    public void CountRepeats_testTesthistest_2()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test", "Test this test.");
      Assert.Equal(newRepeatCounter.CountRepeats(), 2);
    }
    // [Fact] //8
    // public void CountRepeats_testtesthyphendrivendevelopmentcantestyoursoul_2()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter("test", "Test-driven development can test yours soul.");
    //   Assert.Equal(newRepeatCounter.CountRepeats(), 2);
    // }
    // [Fact] //9
    // public void CountRepeats_testhyphendrivenisittesthyphendrivenortestdriven_1()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter("test-driven", "Is it test-driven or test driven? Hyphen yea or nay?");
    //   Assert.Equal(newRepeatCounter.CountRepeats(), 1);
    // }
    // [Fact] //10
    // public void CountRepeats_testItshashtagtestdayexclamationpoint_3()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter("test", "It's #test day! Follow @test for a new TEST!");
    //   Assert.Equal(newRepeatCounter.CountRepeats(), 3);
    // }
    // [Fact] //11
    // public void CountRepeats_testItsdoublehashtagtestday_2()
    // {
    //   RepeatCounter newRepeatCounter = new RepeatCounter("test", "It's ##test day! That's right, double hashtags because I love to TEST!!!!");
    //   Assert.Equal(newRepeatCounter.CountRepeats(), 2);
    // }

  }
}

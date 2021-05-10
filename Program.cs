using System;
using FluentAssertions;

namespace application_structure_checkpoint
{
  class Program
  {
    static void Main(string[] args)
    {
      // Do nothing
    }
    public void additionMethod()
    {
      var first = 3;
      var second = 7;
      var result = first + second;

      result.Should().Be(10);
    }
  }
}

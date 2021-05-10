using System;

namespace application_structure_checkpoint
{
  class Program
  {
    public void additionMethod()
    {
      var first = 3;
      var second = 7;
      var result = first + second;

      result.Should().Be(10);
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}

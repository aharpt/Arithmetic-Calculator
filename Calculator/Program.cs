using System;

namespace Calculator
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(Arithmetic.add(5, 4));
      Console.WriteLine(Area.areaOfRectangle(8, 7));
      Console.WriteLine(Trigonometric.findHypotenuse(3, 4));
    }
  }
}


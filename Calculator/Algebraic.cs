using System;
namespace Calculator
{
  public class Algebraic
  {
    public static int getExponent(int number, int power) {

      int exponentiatedNumber = 1;

      for (int i = 0; i < power; i++)
      {
        exponentiatedNumber *= number;
      }

      return exponentiatedNumber;
    }

    public static string isGreaterThan(double number1, double number2) {
      if (number1 > number2)
      {
        return number1 + " is greater than " + number2;
      }
      else if (number2 > number1)
      {
        return number2 + " is greater than " + number1;
      }
      else {
        return number1 + " and " + number2 + " are equal";
      }
    }
  }
}

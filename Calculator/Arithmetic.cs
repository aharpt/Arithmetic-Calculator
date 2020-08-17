using System;
namespace Calculator
{
  public class Arithmetic
  {
    // private methods

    private static string reduceFraction(double numerator, double denominator)
    {

      double num = numerator;
      double denom = denominator;

      while (denom % 2 == 0 && num % 2 == 0)
      {
        denom /= 2;
        num /= 2;
      }


      if (num == denom)
      {
        return String.Format("{0}", (num + "/" + denom)) + " (equals 1)";
      }
      else
      {
        return String.Format("{0}", (num + "/" + denom));
      }
    }

    // addition functions

    public static string add(int number1, int number2)
    {
      return String.Format("{0:0.00}", (number1 + number2));
    }

    public static string add(double number1, double number2)
    {
      return String.Format("{0:0.00}", (number1 + number2));
    }
    public static string add(int number1, double number2)
    {
      return String.Format("{0:0.00}", (number1 + number2));
    }

    // subtraction functions

    public static string subtract(int number1, int number2) {
      return String.Format("{0:0.00}", (number1 - number2));
    }

    public static string subtract(double number1, double number2) {
      return String.Format("{0:0.00}", (number1 - number2));
    }

    public static string subtract(int number1, double number2) {
      return String.Format("{0:0.0}", (number1 - number2));
    }

    // multiply functions

    public static string multiply(int number1, int number2) {
      return String.Format("{0:0.00}", (number1 * number2));
    }

    public static string multiply(int number1, double number2) {
      return String.Format("{0:0.00}", (number1 * number2));
    }

    public static string multiply(double number1, double number2) {
      return String.Format("{0:0.00}", (number1 * number2));
    }

    // division functions

    public static string divide(int number1, int number2) {
      return String.Format("{0:0.00}", (number1 / number2));
    }

    public static string divide(int number1, double number2) {
      return String.Format("{0:0.00}", (number1 / number2));
    }

    public static string divide(double number1, int number2) {
      return String.Format("{0:0.00}", (number1 / number2));
    }

    public static string divide(double number1, double number2) {
      return String.Format("{0:0.00}", (number1 / number2));
    }

    // fractions

    public static string multiplyFractions(int numerator1, int denominator1, int numerator2, int denominator2) {
      string numerator = String.Format("{0}", (numerator1 * numerator2));
      string denominator = String.Format("{0}", (denominator1 * denominator2));

      return numerator + "/" + denominator;
    }

    public static string divideFractions(int numberator1, int denominator1, int numerator2, int denominator2) {
      string numerator = String.Format("{0}", (numberator1 * denominator2));
      string denominator = String.Format("{0}", (numerator2 * denominator1));

      return numerator + "/" + denominator;
    }

    public static string addFractions(int numerator1 /* 3 */, int denominator1 /* 4 */, int numerator2/* 4 */, int denominator2 /* 5 */) {

      double num1 = numerator1 * denominator2; // 15
      double num2 = numerator2 * denominator1; // 16

      double denom = denominator1 * denominator2; // 20

      double num = num1 + num2; // 31

      string reducedFraction = reduceFraction(num, denom);

      return reducedFraction; // 31/20
    }

    public static string subtractFractions(int numerator1, int denominator1, int numerator2, int denominator2) {
      double num1 = numerator1 * denominator2;
      double num2 = numerator2 * denominator1;

      double denom = denominator1 * denominator2;

      double num = num1 - num2;

      string reducedFraction = reduceFraction(num, denom);

      if (num == 0) {
        reducedFraction = "0";
      }

      return reducedFraction;
    }
  }
}

using System;
namespace Calculator
{
  public class Trigonometric
  {

    // find hypotenuse

    public static string findHypotenuse(int side1, int side2) {
      double hypotenuse = Math.Sqrt((side1 * side1) + (side2 * side2));

      return String.Format("{0:0.00}", hypotenuse);
    }

    public static string findHypotenuse(int side1, double side2) {
      double hypotenuse = Math.Sqrt((side1 * side1) + (side2 * side2));

      return String.Format("{0:0.00}", hypotenuse);
    }

    public static string findHypotenuse(double side1, int side2) {
      double hypotenuse = Math.Sqrt((side1 * side1) + (side2 * side2));

      return String.Format("{0:0.00}", hypotenuse);
    }

    public static string findHypotenuse(double side1, double side2) {
      double hypotenuse = Math.Sqrt((side1 * side1) + (side2 * side2));

      return String.Format("{0:0.00}", hypotenuse);
    }

    // find side

    public static string findSide(int side, int hypotenuse) {
      double missingSide = Math.Sqrt((hypotenuse * hypotenuse) - (side * side));

      return String.Format("{0:0.00}", missingSide);
    }

    public static string findSide(int side, double hypotenuse) {
      double missingSide = Math.Sqrt((hypotenuse * hypotenuse) - (side * side));

      return String.Format("{0:0.00}", missingSide);
    }

    public static string findSide(double side, int hypotenuse) {
      double missingSide = Math.Sqrt((hypotenuse * hypotenuse) - (side * side));

      return String.Format("{0:0.00}", missingSide);
    }

    public static string findSide(double side, double hypotenuse) {
      double missingSide = Math.Sqrt((hypotenuse * hypotenuse) - (side * side));

      return String.Format("{0:0.00}", missingSide);
    }

    /*  trigonometric functions.
     *  ENTER angles in RADIANS */

    public static string getSine(double angle) {
      return String.Format("{0:0.00}", (Math.Sin(angle)));
    }

    public static string getCosine(double angle) {
      return String.Format("{0:0.00}", (Math.Cos(angle)));
    }

    public static string getTangent(double angle) {
      return String.Format("{0:0.00}", (Math.Tan(angle)));
    }

    // Logarithms

    public static string getLogarithm(double number, double newBase) {
      return String.Format("{0:0.00}", (Math.Log(number, newBase)));
    }

    public static string base10Logarithm(double number) {
      return String.Format("{0:0.00}", (Math.Log10(number)));
    }
  }
}

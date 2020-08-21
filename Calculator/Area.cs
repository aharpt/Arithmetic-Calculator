using System;
namespace Calculator
{
  // Stack Overflow how to output a number with two spaces after the decimal point https://stackoverflow.com/questions/1291483/leave-only-two-decimal-places-after-the-dot
  public class Area
  {
    public static string areaOfRectangle(int width, int length) {
      return String.Format("{0:0.00}", (width * length));
    }

    public static string areaOfRectangle(int width, double length) {
      return String.Format("{0:0.00}", (width * length));
    }

    public static String areaOfRectangle(double width, int length) {
      return String.Format("{0:0.00}", (width * length));
    }

    public static String areaOfRectangle(double width, double length) {
      return String.Format("{0:0.00}", (width * length));
    }
  }
}

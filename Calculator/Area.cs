using System;
namespace Calculator
{
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

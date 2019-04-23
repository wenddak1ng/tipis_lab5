using System;

namespace MassConverter {

  public static class Converter {

    static double result;
    const double pound = 0.4536;
    const double gramm = 0.001;
    const double ounce = 31.1035 * gramm;
    const double slug = 14.5939;

    public static double ConvertFromKgToPound(double mass) {
      result = mass / pound;
      return result;
    }

    public static double ConvertFromKgToOunce(double mass) {
      result = mass * ounce;
      return result;
    }

    public static double ConvertFromOunceToGr(double mass) {
      result = mass * gramm;
      return result;
    }

    public static double ConvertFromKgToSlug(double mass) {
      result = mass / slug;
      return result;
    }
  }

  public class Output {
    public double ounce;
    public double gramm;
    public static Output Add_Multiply(double a, double b) {
      var res = new Output {
          ounce = a,
          gramm = b
      };
      return res;
    }
  }
}
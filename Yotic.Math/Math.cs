using SMath = System.Math;

namespace Yotic;
public static class Math
{
    public static double floor(double value) => SMath.Floor(value);
    public static int floorI(double value) => (int)SMath.Floor(value);

    public static double pow(double value, int power) => SMath.Pow(value, power);
    public static double pow(double value) => value * value;
    public static float pow(float value, int power) => MathF.Pow(value, power);
    public static float pow(float value) => value * value;

    public static double round(double value) => SMath.Round(value);
    public static double round(double value, int digits) => SMath.Round(value, digits);

    public static float round(float value) => MathF.Round(value);
    public static float round(float value, int digits) => MathF.Round(value, digits);
}
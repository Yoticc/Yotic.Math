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

    public static double max(params double[] values)
    {
        if (values.Length == 0)
            return double.NaN;

        var max = values[0];
        for (var i = 1; i < values.Length; i++)
            if (max < values[i])
                max = values[i];
        return max;
    }
    public static float max(params float[] values)
    {
        if (values.Length == 0)
            return float.NaN;

        var max = values[0];
        for (var i = 1; i < values.Length; i++)
            if (max < values[i])
                max = values[i];
        return max;
    }
    public static int max(params int[] values)
    {
        if (values.Length == 0)
            return 0;

        var max = values[0];
        for (var i = 1; i < values.Length; i++)
            if (max < values[i])
                max = values[i];
        return max;
    }

    public static double min(params double[] values)
    {
        if (values.Length == 0)
            return double.NaN;

        var min = values[0];
        for (var i = 1; i < values.Length; i++)
            if (min > values[i])
                min = values[i];
        return min;
    }
    public static float min(params float[] values)
    {
        if (values.Length == 0)
            return float.NaN;

        var min = values[0];
        for (var i = 1; i < values.Length; i++)
            if (min > values[i])
                min = values[i];
        return min;
    }
    public static int min(params int[] values)
    {
        if (values.Length == 0)
            return 0;

        var min = values[0];
        for (var i = 1; i < values.Length; i++)
            if (min > values[i])
                min = values[i];
        return min;
    }
}
namespace Ballistics.Core.Math
{
    public static class Scalar
    {
        public const double Epsilon = 1e-12;

        public static bool AlmostZero(double value)
        {
            return System.Math.Abs(value) < Epsilon;
        }
    }
}
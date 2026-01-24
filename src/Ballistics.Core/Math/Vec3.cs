namespace Ballistics.Core.Math
{
    public struct Vec3
    {
        public double X;
        public double Y;
        public double Z;

        public Vec3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vec3 Subtract(Vec3 other)
        {
            return new Vec3(
                X - other.X,
                Y - other.Y,
                Z - other.Z
            );
        }
    }
}

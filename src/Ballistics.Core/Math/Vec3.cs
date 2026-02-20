namespace Ballistics.Core.Math
{
    public struct Vec3
    {
        public readonly double X;
        public readonly double Y;
        public readonly double Z;

        public Vec3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Core math operations.

        public Vec3 Add(Vec3 other)
        {
            return new Vec3(
                X + other.X,
                Y + other.Y,
                Z + other.Z
            );
        }

        public Vec3 Subtract(Vec3 other)
        {
            return new Vec3(
                X - other.X,
                Y - other.Y,
                Z - other.Z
            );
        }

        public Vec3 Multiply(double scalar)
        {
            return new Vec3(
                X * scalar,
                Y * scalar,
                Z * scalar
            );
        }

        public double Magnitude()
        {
            return System.Math.Sqrt(
                (X * X) +
                (Y * Y) +
                (Z * Z)
            );
        }

        public double MagnitudeSquared()
        {
            return (X * X) + (Y * Y) + (Z * Z);
        } 

        public double DoubleDot(Vec3 other)
        {
            return (X * other.X) + (Y * other.Y) + (Z * other.Z);
        }

        public Vec3 Cross(Vec3 other)
        {
            return new Vec3(
                (Y * other.Z) - (Z * other.Y), 
                (Z * other.X) - (X * other.Z),
                (X * other.Y) - (Y * other.X)
            );
        }

        public double Distance(Vec3 other)
        {
            return (this - other).Magnitude();
        }

        public double DistanceSquared(Vec3 other)
        {
            return (this - other).MagnitudeSquared();
        }

        public Vec3 Normalize()
        {
            double mag = Magnitude();

            if (Scalar.AlmostZero(mag))
            {
                return new Vec3(0, 0, 0);
            }

            return new Vec3(
                X / mag,
                Y / mag,
                Z / mag
            );
        }

        // Operator overloads.

        public static Vec3 operator +(Vec3 a, Vec3 b)
        {
            return a.Add(b);
        }

        public static Vec3 operator -(Vec3 a, Vec3 b)
        {
            return a.Subtract(b);
        }

        public static Vec3 operator *(Vec3 v, double scalar)
        {
            return v.Multiply(scalar);
        }

        public static Vec3 operator *(double scalar, Vec3 v)
        {
            return v.Multiply(scalar);
        }
    }
}

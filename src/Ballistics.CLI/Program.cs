using Ballistics.Core.Math;

namespace Ballistics.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            RunVec3SanityChecks();
        }

        static void RunVec3SanityChecks()
        {
            Console.WriteLine("=== Vec3 Sanity Checks ===");

            Vec3 a = new Vec3(3, 4, 0);
            Vec3 b = new Vec3(1, 2, 3);
            Vec3 xAxis = new Vec3(1, 0, 0);
            Vec3 yAxis = new Vec3(0, 1, 0);

            // Basic arithmetic
            Vec3 diff = a - b;
            Vec3 scaled = a * 2;

            Console.WriteLine($"a - b = ({diff.X}, {diff.Y}, {diff.Z})");
            Console.WriteLine($"a * 2 = ({scaled.X}, {scaled.Y}, {scaled.Z})");

            // Magnitude
            double magA = a.Magnitude();
            Console.WriteLine($"|a| = {magA} (expected 5)");

            Check("Magnitude correct",
                System.Math.Abs(magA - 5.0) < Scalar.Epsilon);

            // MagnitudeSquared
            double magSq = a.MagnitudeSquared();
            Check("MagnitudeSquared correct",
                System.Math.Abs(magSq - 25.0) < Scalar.Epsilon);

            // Dot product
            double dot = xAxis.Dot(yAxis);
            Check("Dot orthogonality (x·y = 0)",
                Scalar.AlmostZero(dot));

            // Cross product
            Vec3 cross = xAxis.Cross(yAxis);
            Check("Cross result is Z axis",
                Scalar.AlmostZero(cross.X) &&
                Scalar.AlmostZero(cross.Y) &&
                System.Math.Abs(cross.Z - 1.0) < Scalar.Epsilon);

            // Normalize
            Vec3 normalized = a.Normalize();
            double normalizedMag = normalized.Magnitude();
            Check("Normalize produces unit vector",
                System.Math.Abs(normalizedMag - 1.0) < 1e-9);

            Console.WriteLine("=== Done ===");
        }

        static void Check(string label, bool condition)
        {
            if (condition)
                Console.WriteLine($"[PASS] {label}");
            else
                Console.WriteLine($"[FAIL] {label}");
        }
    }
}
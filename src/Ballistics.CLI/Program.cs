using Ballistics.Core.Math;

namespace Ballistics.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Vec3 a = new Vec3(3, 4, 0);
            Vec3 b = new Vec3(1, 2, 3);

            Vec3 diff = a - b;
            Vec3 scaled = a * 2;

            Console.WriteLine($"a = ({a.X}, {a.Y}, {a.Z})");
            Console.WriteLine($"b = ({b.X}, {b.Y}, {b.Z})");
            Console.WriteLine($"a - b = ({diff.X}, {diff.Y}, {diff.Z})");
            Console.WriteLine($"a * 2 = ({scaled.X}, {scaled.Y}, {scaled.Z})");
            Console.WriteLine($"|a| = {a.Magnitude()}");
        }
    }
}

using System.Diagnostics.Contracts;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Ballistics.Core.Math
{
    public struct Vec3
    {
        public double x;
        public double y;
        public double z;

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
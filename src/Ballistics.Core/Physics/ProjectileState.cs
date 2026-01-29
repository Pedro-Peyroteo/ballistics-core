using Ballistics.Core.Math;

namespace Ballistics.Core.Physics
{
    public struct ProjectileState
    {
        public Vec3 Position;
        public Vec3 Velocity;

        public ProjectileState(Vec3 position, Vec3 velocity)
        {
            Position = position;
            Velocity = velocity;
        }
    }
}

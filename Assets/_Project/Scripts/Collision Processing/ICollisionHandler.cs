using UnityEngine;

namespace _Project.Scripts.Collision_Processing
{
    /// <summary>
    /// Extend for custom collision things, separates the responsibility of collisions on to other components
    /// </summary>
    public interface ICollisionHandler
    {
        void ProcessCollision(GameObject other, CollisionType type);
    }
}

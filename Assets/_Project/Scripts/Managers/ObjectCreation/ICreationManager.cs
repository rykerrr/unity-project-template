using UnityEngine;

namespace _Project.Scripts.Managers.ObjectCreation
{
    /// <summary>
    /// Sort of like an interface for a game object factory
    /// Extend for custom instantiation behaviors
    /// May be removed in the future due to how ManagerManager works, there isn't much use to having an interface
    /// as it'll rely on types for managers anyway
    /// </summary>
    public interface ICreationManager
    {
        /// <summary>
        /// Basically like a normal instantiation call, but whether it's actually an instantiation,
        /// a "reactivation", or pooling, or something else, we leave up to the implementation
        /// </summary>
        /// <param name="prefab"></param>
        /// <param name="position"></param>
        /// <param name="rotation"></param>
        /// <returns></returns>
        GameObject CreateObj(GameObject prefab, Vector3 position, Quaternion rotation);
        
        /// <summary>
        /// Again, just like a normal instantiation call, but this time with parent 
        /// </summary>
        /// <param name="prefab"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        GameObject CreateObj(GameObject prefab, Transform parent);
    }
}
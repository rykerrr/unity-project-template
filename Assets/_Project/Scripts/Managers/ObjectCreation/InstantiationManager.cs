using UnityEngine;

namespace _Project.Scripts.Managers.ObjectCreation
{
    /// <summary>
    /// Delegation of runtime instantiation responsibility to a single object, this acts as sort of a factory
    /// No need for it to be a Singleton as it'll always be under GameController, which already is a singleton
    /// </summary>
    public class InstantiationManager : MonoBehaviour, ICreationManager, IManagerObject
    {
        public GameObject CreateObj(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            var clone = Instantiate(prefab, position, rotation);

            return clone;
        }

        public GameObject CreateObj(GameObject prefab, Transform parent)
        {
            var clone = CreateObj(prefab, Vector3.zero, Quaternion.identity).transform;

            clone.parent = parent;
            clone.localPosition = Vector3.zero;

            return clone.gameObject;
        }
    }
}
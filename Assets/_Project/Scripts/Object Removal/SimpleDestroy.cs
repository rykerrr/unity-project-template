using UnityEngine;

namespace _Project.Scripts.Object_Removal
{
    public class SimpleDestroy : MonoBehaviour, IRemovalHandler
    {
        public void Remove()
        {
            Destroy(gameObject);
        }
    }
}
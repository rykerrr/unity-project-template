using UnityEditor;
using UnityEditorInternal;
using UnityEngine.Events;

namespace _Project.Scripts.Editor
{
    [CustomPropertyDrawer(typeof(UnityEventBase), true)]
    public class BaseCustomUnityEventDrawer : UnityEventDrawer
    {
        protected override void SetupReorderableList(ReorderableList list)
        {
            base.SetupReorderableList(list);
 
            list.draggable = true;
        }
    }
}
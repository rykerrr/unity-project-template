namespace _Project.Scripts.Object_Removal
{
    /// <summary>
    /// Extend this for custom "removal", e.g adding coins on pickup, separates responsibility of object removal on to other components
    /// </summary>
    public interface IRemovalHandler
    {
        void Remove();
    }
}
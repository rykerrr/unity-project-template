namespace _Project.Scripts.Timers
{
    /// <summary>
    /// Extend this for custom timers
    /// </summary>
    public interface ITimer
    {
        float Time { get; }
        bool IsTimerEnabled { get; }

        bool TryTick(float deltaTime);
        void EnableTimer();
        void DisableTimer();
        void Reset();
    }
}
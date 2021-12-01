namespace _Project.Scripts.Timers
{
    /// <summary>
    /// Base class to DRY timers with similar behaviour, inherit if it shares similar behaviour to DownTimer or StopWatch
    /// </summary>
    public abstract class BaseTimer : ITimer
    {
        public bool IsTimerEnabled { get; private set; } = true;

        public float Time
        {
            get;
            protected set;
        }

        public void EnableTimer() => IsTimerEnabled = true;
        public void DisableTimer() => IsTimerEnabled = false;
        public abstract void Reset();

        public abstract bool TryTick(float time);
    }
}
using System;

namespace _Project.Scripts.Timers
{
    /// <summary>
    /// Essentially an up-timer with no direct "limit"
    /// </summary>
    public class StopWatch : BaseTimer
    {
        public StopWatch(float time)
        {
            Time = time;
        }

        public override bool TryTick(float deltaTime)
        {
            if (deltaTime < 0 || !IsTimerEnabled) return false;
        
            Time = Math.Max(Time + deltaTime, 0);
            return true;
        }

        public override void Reset()
        {
            Time = 0;
        }
    }
}
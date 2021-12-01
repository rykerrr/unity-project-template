using System;

namespace _Project.Scripts.Timers
{
    /// <summary>
    /// Default down timer behaviour
    /// </summary>
    public class DownTimer : BaseTimer
    {
        private float defaultTime = default;
        public float DefaultTime => defaultTime;

        public Action OnTimerEnd { get; set; } = delegate { };

        public DownTimer(float time)
        {
            SetNewDefaultTime(time);

            Reset();
        }

        public void SetNewDefaultTime(float time)
        {
            defaultTime = Math.Max(time, 0);

            // Time = defaultTime;
        }

        /// <summary>
        /// Call instead of SetNewDefaultTime to avoid having to call reset afterwards
        /// </summary>
        /// <param name="time"></param>
        public void SetNewTime(float time)
        {
            SetNewDefaultTime(time);

            Reset();
        }

        /// <summary>
        /// Timer loop
        /// </summary>
        /// <param name="deltaTime"></param>
        /// <returns></returns>
        public override bool TryTick(float deltaTime)
        {
            var timerFinished = Time == 0;
            var deltaTimeIsNegative = deltaTime < 0;

            if (timerFinished || deltaTimeIsNegative || !IsTimerEnabled) return false;

            Time = Math.Max(Time - deltaTime, 0);

            // If time is equal to 0, this should run, only THEN should we be able to check if it's 0 in the first line of this
            // method
            // Unless it starts off at 0
            // Then what the flustertruck is going on

            if (Time == 0)
            {
                OnTimerEnd?.Invoke();
            }

            return true;
        }

        public override void Reset()
        {
            Time = defaultTime;
        }
    }
}
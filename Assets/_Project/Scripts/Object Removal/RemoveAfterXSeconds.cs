using _Project.Scripts.Timers;
using UnityEngine;

namespace _Project.Scripts.Object_Removal
{
    /// <summary>
    /// Effectively just a timer with an IRemovalHandler
    /// Behaviour similar to Destroy(object, time) method overload of Destroy, or a timed Invoke call with Destroy 
    /// </summary>
    [RequireComponent(typeof(IRemovalHandler))]
    public class RemoveAfterXSeconds : MonoBehaviour
    {
        private IRemovalHandler removalProcessor;
        private ITimer timer;

        private void Awake()
        {
            removalProcessor = GetComponent<IRemovalHandler>();

            timer = new DownTimer(0f);
            timer.DisableTimer();
            ((DownTimer) timer).OnTimerEnd += removalProcessor.Remove;
        }
		
        private void Update()
        {
            var ticked = timer.TryTick(Time.deltaTime);
        }
		
        public void Remove(float seconds)
        {
            ((DownTimer) timer).SetNewTime(seconds);
            timer.EnableTimer();
        }
    }
}
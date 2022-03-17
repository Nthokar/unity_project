using System;
using UnityEngine;

namespace global
{
    public class TimeManager
    {
        public static Action OnNewDay;
        public static Action OnNewMonth;
        private Timer _timer = new Timer();

        public static void SendNewDay()
        {
            if (OnNewDay != null) OnNewDay.Invoke();
        }
        public static void SendNewMonth()
        {
            if (OnNewDay != null) OnNewMonth.Invoke();
        }
        public void UpdateData()
        {
            _timer.UpdateData(Time.deltaTime);
            Debug.Log(_timer.GetDay().ToString() + ' ' + _timer.GetMounth().ToString() + ' ');
        }
    }
}

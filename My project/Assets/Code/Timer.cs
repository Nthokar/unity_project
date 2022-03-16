using System;
using UnityEngine;

namespace global
{
    public class Timer : MonoBehaviour
    {
        public Action action;
        public int Year = 2000;

        private int _mounth;
        public int GetMounth() => _mounth;
        public void IncreseMounth()
        {
            _mounth++;
            if (_mounth == 13)
            {
                _mounth = 1;
                Year++;
            }
        }

        private int _day;
        public int GetDay() => _day;
        public void IncreaseDay()
        {
            _day++;
            TimeManager.SendNewDay();
            if (_day == 31)
            {
                _day = 1;
                IncreseMounth();
            }

        }

        public float SecondInDay = 2f;
        public float TimeCounter;
        public void UpdateData(float time)
        {
            TimeCounter += time;
            if (TimeCounter > SecondInDay)
            {
                TimeCounter = 0;
                IncreaseDay();
            }
        }

        public void Update()
        {
            UpdateData(Time.deltaTime);
            Debug.Log(GetDay().ToString() + ' ' + GetMounth().ToString() + ' ');
        }
    }
}
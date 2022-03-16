using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace global
{
    public class Emploee : MonoBehaviour
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Salary { get; set; }
        private int DevPointsPerStep = 1;

        public int GetDevPoints()
        {
            return DevPointsPerStep;
        }

        //public void AnimationWork()
        //public static void WriteXML()

        public Emploee()
        { }

        public Emploee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
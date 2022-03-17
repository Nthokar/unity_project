using UnityEngine;


namespace global
{
    public class Emploee : MonoBehaviour
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public int level;

        public int Salary { get; private set; }
        private int _devPointsPerStep = 1;

        public int GetDevPoints()
        {
            return _devPointsPerStep;
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
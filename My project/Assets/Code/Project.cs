using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace global
{
    public class Project
    {
        public string Status;

        public string Name { get; set; }

        public Project ()
        { }
        public Project(string name)
        {
            this.Name = name;
            Status = "development";
        }

        //public void Equals()
        //{

        //}
        //public static bool operator ==()
    }
}
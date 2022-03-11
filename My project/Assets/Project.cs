using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace global
{
    public class Project
    {
        public string name { get; set; }

        public Project ()
        { }
        public Project(string name)
        {
            this.name = name;
        }
    }
}
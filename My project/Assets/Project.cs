using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace global
{
    public class Project : MonoBehaviour
    {
        public string name { get; set; }
        public Button addProjectBotton;
        public Text text;

        public Project (string name)
        {
            this.name = name;
        }

        public void AddPtoject()
        {
            text.text = text.text + name + "\n";
        }


    }
}
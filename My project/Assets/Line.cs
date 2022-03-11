using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace global
{
    public class Line : MonoBehaviour
    {
        public Project Value;
        public bool isOnScreen;
        private static Line instance;
        public GameObject TemplateLineUI;


        public Line(Project project)
        {
            Value = project;
        }
        public Line(Line line)
        {
            Value = line.Value;
        }

        public void Awake()
        {
            if (instance == null)
                instance = this;
            else if(instance != this)
                Destroy(this.gameObject);
        }

        public void ShowWindow()
        {
            GameObject window = Instantiate(TemplateLineUI);
            window.GetComponent<Text>().text = Value.name;
        }
    }
}

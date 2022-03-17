using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace global
{
    public class ProjectInfoWindow : PopUpWindow
    {
        public Line _line;
        public Text textField;

        public void ShowWindow(Line line)
        {
            textField.text = line.textField.text;
            GameObject window = Instantiate(Template) as GameObject;
            Parent = GameObject.Find("UILayouts");
            window.transform.parent = Parent.transform;
        }
    }
}
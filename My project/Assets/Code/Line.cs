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
        public Text textField;
        public GameObject instance;

        private GameObject _parent;

        public bool Equals(Object obj)
        {
            if (!(obj is Line)) return false;
            var line = (Line)obj;
            return this.Value.Equals(line.Value);

        }

        public static bool operator ==(Line line1, Line line2)
        {
            if ((line1 is null) && (line2 is null)) return true;
            if (!(line1 is Line) || !(line2 is Line)) return false;
            return line1.Value == line2.Value;
        }

        public static bool operator !=(Line line1, Line line2)
        {
            return !(line1 == line2);
        }
        public Line(Project project)
        {
            Value = project;
        }
        public Line(GameObject template)
        {
            instance = Instantiate(template);
            
        }

        public Line(Project project, GameObject template)
        {
            Value = project;
            textField = template.GetComponentInChildren<Text>();
            textField.text = Value.Name;
            _parent = GameObject.Find("ProjectListWindow");
            instance = Instantiate(template);
            instance.transform.parent = _parent.transform;

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace global
{
    public class ProjectCreationWindow : MonoBehaviour
    {
        private static ProjectCreationWindow instance;
        public GameObject Template;
        public GameObject Player;
        public InputField inputField;
        public GameObject parent;

        public ProjectCreationWindow(ProjectCreationWindow clone)
        {
            Template = clone.Template;
        }
        public void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance  != this)
            {
                Destroy(this.gameObject);
            }
        }
        public void ShowWindow()
        {
            GameObject window = Instantiate(Template) as GameObject;
            parent = GameObject.Find("UILayouts");
            window.transform.parent = parent.transform;

        }
        public void CreateProject()
        {
            Player.GetComponent<Company>().CreateProject(new Project(inputField.text));
        }
    }
}

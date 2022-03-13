using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace global
{
    public class ProjectCreationWindow : PopUpWindow
    {
        public InputField inputField;

        public void CreateProject()
        {
            Player.GetComponent<Company>().CreateProject(new Project(inputField.text));
        }
    }
}

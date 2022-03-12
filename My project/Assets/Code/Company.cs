using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace global
{
    public class Company : MonoBehaviour
    {
        public string name { get; }
        public int balance { get; private set; }

        public ProjectList projectList = new ProjectList();

        public GameObject Template;

        public void Start()
        {

        }
        public void Update()
        {
            
        }

        public void CreateProject(Project project)
        {
            projectList.Add(project);
        }
    }
}
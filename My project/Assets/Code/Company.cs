using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace global
{
    public class Company : MonoBehaviour
    {
        public string Name { get; }
        public int Balance { get; private set; }

        public GameObject Template;
        public ProjectList Projects;
        public List<Emploee> Emploees;
        public TimeManager TimeManager = new TimeManager();
        public void Awake()
        {
            Projects = new ProjectList();
            Emploees = new List<Emploee>();
            TimeManager.OnNewDay += DevelopAllProjects;
        }
        //public void FixedUpdate()
        //{
        //    for (int i = 0; i < Projects.Count; i++)
        //    {
        //        if (Projects[i].timeLeft > 0)
        //        {
        //            Projects[i].timeLeft -= Time.deltaTime;
        //            if (Projects[i].timeLeft <= 0)
        //                Projects[i].Status = "relese";
        //        }
        //        Projects[i].UpdateNumberOfUsers();
        //        Debug.Log(Projects[i].timeLeft + " " + Projects[i].GetNumberOfUsers());
        //    }
        //}

        public void DevelopAllProjects()
        {
            for (int i = 0; i < Projects.Count; i++)
            {
                Projects[i].Develop();
            }
        }

        public void CreateProject(Project project)
        {
            project.Employees.Add(GameObject.Find("Steve(Emploee)").GetComponent<Emploee>());
            Projects.Add(project);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectCreationWindow : MonoBehaviour
{
    private static ProjectCreationWindow instance;
    public GameObject Template;

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

        GameObject window = Instantiate(new ProjectCreationWindow(this).Template);
    }
}

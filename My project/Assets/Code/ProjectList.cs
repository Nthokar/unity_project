using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace global
{
    public  class ProjectList
    {
        public List<Project> list = new List<Project>();
        public int count { get => list.Count;}

        public Project this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                return list[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                list[index] = value;
            }
        }

        public ProjectList ()
        {

        }

        public void Add(Project project)
        {
            list.Add(project);
        }

        public void Sort()
        {
            list.Sort();
        }
    }
}
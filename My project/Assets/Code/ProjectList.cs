using System;
using System.Collections.Generic;

namespace global
{
    public  class ProjectList
    {
        public List<Project> list = new List<Project>();
        public int Count { get => list.Count; }

        public Project this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
                return list[index];
            }
            set
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
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
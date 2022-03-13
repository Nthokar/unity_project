using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace global
{
    public class ProjectListWindow : MonoBehaviour
    {
        public Company Company;
        public GameObject LineTemplate;
        public Line[] lineArray = new Line[4];

        public void Update()
        {
            UpdateArray();
        }

        //public void ShowLine(Line line)
        //{
        //    if (line.isOnScreen)    return;
        //    Instantiate(LineTemplate);
        //}

        private void UpdateArray()
        {
            for (int i = 0; i < 4 && i < Company.projectList.count; i++)
            {
                if (lineArray[i] == null)
                {
                    lineArray[i] = new Line(Company.projectList[i], LineTemplate);
                    lineArray[i].Value = Company.projectList[i];
                    var x = lineArray[i].instance.transform.position.x;
                    var y = lineArray[i].instance.transform.position.y;
                    var z = lineArray[i].instance.transform.position.z;
                    lineArray[i].instance.transform.position = new Vector3(x, y - 60*i, z);
                }
                if (Company.projectList[i] != lineArray[i].Value)
                {
                    lineArray[i] = new Line(Company.projectList[i]);
                    lineArray[i].Value = Company.projectList[i];
                }
             }
        }
    }
}

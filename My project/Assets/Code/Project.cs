using System;
using System.Collections.Generic;
using UnityEngine;

namespace global
{
    public class Project
    {
        //"development"
        //"relese"/"maintenance"
        //"closed"
        public string Status;

        public string Name { get; set; }
        public int NumberOfUsers;
        const float _stonksNumberOfUsers = 0.02f; 
        public float interes;

        public List<Emploee> Employees = new List<Emploee> { };

        public int DevPointsNecessary { get => /*technology*/ 10; }
        public int DevPointsFilled = 0;

        public Project ()
        {
            Status = "development";
        }
        public Project(string name)
        {
            this.Name = name;
            Status = "development";
        }

        //ћожно оптимизировать посредству единоразового расчета прироста очков за шаг
        private void DoStep()
        {
            foreach (var item in Employees)
            {
                if (Employees == null) throw new NullReferenceException();
                DevPointsFilled += item.GetDevPoints();
            }
        }

        //ћожно завернуть в карутину :)
        public void Develop()
        {
            if (DevPointsFilled < DevPointsNecessary && Status != "relese")
            {
                DoStep();
                Debug.Log(DevPointsFilled);
            }
            else
            {
                Status = "relese";
                Debug.Log("Project developed!!!");
            }
        }

        public int GetNumberOfUsers()
        {
            return NumberOfUsers;
        }

        public int GetNewUsers()
        {
            return (int) (NumberOfUsers * _stonksNumberOfUsers) + UnityEngine.Random.Range(10, 20);
        }

        public void UpdateNumberOfUsers()
        {
            if (Status == "relese")
                NumberOfUsers += GetNewUsers();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace global
{
    public class Company : MonoBehaviour
    {
        public string name { get; }
        public int balance { get; private set; }

        public List<Project> list;
    }
}
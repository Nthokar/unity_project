using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace global
{
    public class GameInit : MonoBehaviour
    {
        public Company company;
        // Start is called before the first frame update
        void Start()
        {
            Instantiate(company);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
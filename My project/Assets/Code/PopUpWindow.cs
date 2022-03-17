using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace global
{
    public class PopUpWindow : MonoBehaviour
    {
        public GameObject Player;
        public GameObject Parent;
        public GameObject Template;
        private static PopUpWindow instance;

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
            GameObject window = Instantiate(Template) as GameObject;
            Parent = GameObject.Find("UILayouts");
            window.transform.parent = Parent.transform;
        }

        public void DestroyWindow()
        {
            Destroy(gameObject);
        }
    }
}
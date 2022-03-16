using UnityEngine;

namespace global
{
    public class ProjectListWindow : MonoBehaviour
    {
        public GameObject LineTemplate;
        private Company _company;
        private Line[] _lineArray = new Line[4];


        public void Awake()
        {
            _company = GameObject.Find("Player").GetComponent<Company>();
        }
        public void Start()
        {
            _company = GameObject.Find("Player").GetComponent<Company>();
        }
        private void Update()
        {
            UpdateScreen();
        }
        public void UpdateArray()
        {
            _company = GameObject.Find("Player").GetComponent<Company>();
            for (int i = 0; i < 4 && i < _company.Projects.Count; i++)
            {
                if (_lineArray[i] == null)
                {
                    _lineArray[i] = new Line(_company.Projects[i], LineTemplate);
                    _lineArray[i].Value = _company.Projects[i];
                    var x = _lineArray[i].instance.transform.position.x;
                    var y = _lineArray[i].instance.transform.position.y;
                    var z = _lineArray[i].instance.transform.position.z;
                    _lineArray[i].instance.transform.position = new Vector3(x, y - 60*i, z);
                }
                if (_company.Projects[i] != _lineArray[i].Value)
                {
                    _lineArray[i] = new Line(_company.Projects[i]);
                    _lineArray[i].Value = _company.Projects[i];
                }
                DequeueRelesed(ref _lineArray[i]);
            }
        }
        public void UpdateByQueue()
        {
            _company = GameObject.Find("Player").GetComponent<Company>();
            int count = _company.Projects.Count - 1;
            for (int i = 3; i > 0; i--)
            {
                float x, y, z;
                if (_lineArray[i-1] != null)
                {
                    _lineArray[i] = _lineArray[i - 1];
                    x = _lineArray[i - 1].instance.transform.position.x;
                    y = _lineArray[i - 1].instance.transform.position.y;
                    z = _lineArray[i - 1].instance.transform.position.z;
                    _lineArray[i].instance.transform.position = new Vector3(x, y - 60, z);
                }
                DequeueRelesed(ref _lineArray[i]);
            }
            if (count > 0)
                _lineArray[0] = new Line(_company.Projects[count], LineTemplate);
            DequeueRelesed(ref _lineArray[0]);
        }

        private void DequeueRelesed(ref Line line)
        {
            if (line != null)
            {
                if (line.Value.Status == "relese")
                {
                    line.IsOnScreen = false;
                    Destroy(line.instance);
                    line = null;
                }
            }
        }

        public void UpdateScreen()
        {
            _company = GameObject.Find("Player").GetComponent<Company>();
            for (int i = 0; i < _lineArray.Length && i < _company.Projects.Count; i++)
            {
                if (_lineArray[i] == null)
                {
                    _lineArray[i] = new Line(_company.Projects[_company.Projects.Count - 1], LineTemplate);
                }
                if (_lineArray[i] != null)
                {
                    var x = LineTemplate.transform.position.x;
                    var y = LineTemplate.transform.position.y;
                    var z = LineTemplate.transform.position.z;
                    _lineArray[i].instance.transform.position = new Vector3(x, y - 60*i, z);
                }
                //_lineArray[i].DestroyIfStatus("relese");
                DequeueRelesed(ref _lineArray[i]);
            }
        }
    }
}

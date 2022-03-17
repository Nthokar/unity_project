using UnityEngine;

namespace global
{
    public class FreeEmploeesList
    {
        private static int _maxEmploees = 10;
        public int Count;
        private Emploee[] _emploees = new Emploee[_maxEmploees];

        public void UpdateEmploees()
        {
            DeleteRandomEmploees();
            AddRandomEmploees();
        }

        private void AddRandomEmploees()
        {
            var numberOfRandomEmploees = Random.Range(1, _maxEmploees/2);   // <= рандомное число новых пользователей
                                                                                        // параметры можно менять
            for (var i = 0; i < _maxEmploees && 0 < numberOfRandomEmploees; i++)
            {
                var emploee = _emploees[i];
                if (emploee == null)
                {
                    emploee = new Emploee();
                    numberOfRandomEmploees--;
                }
            }


        }

        private void DeleteRandomEmploees() // тут проблема, что могу зарандомится одинаковые индексы, надо исправить
        {
            var numberOfRandomEmploees = Random.Range(1, _maxEmploees/2);
            for (var i = 0; i < numberOfRandomEmploees; i++)
            {
                int randomIndex = Random.Range(0, _maxEmploees - 1);
                GameObject.Destroy(_emploees[randomIndex]);
                _emploees[randomIndex] = null;
            }
        }
    }
}

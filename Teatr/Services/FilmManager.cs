using Core.Models;
using Core.Services.Contracts;
using Teatr.Models;

namespace Teatr.Services
{
    internal class FilmManager : ICrudService, IPrintService
    {
        private Film[] _films = new Film[4];
        private int _currentIndex;
        public void Add(Entity entity)
        {
            if (_currentIndex > 3)
            {
                Console.WriteLine("Limiti kecdiniz en cox 5 film elave ede biler!!!");
            }
            _films[_currentIndex++] = (Film)entity;
        }
        public void Delete(int id)
        {
            bool find = false;
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i] == null)
                    continue;

                if (id == _films[i].Id)
                {
                    find = true;

                    for (int j = i; j < _films.Length - 1; j++)
                    {
                        _films[j] = _films[j + 1];
                    }
                    _currentIndex--;
                    Console.WriteLine($"{id} id-li film silindi!!");
                    return;
                }
            }
        }
        public Entity Get(int id)
        {
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i] == null)
                    continue;

                if (id == _films[i].Id)
                {
                    Console.WriteLine(_films[i]);
                    return _films[i];
                }
            }
            Console.WriteLine("Not Found!!");
            return null;
        }

        public void Print()
        {
            foreach (var item in _films)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }
        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i] == null)
                    continue;

                if (_films[i].Id == id)
                {
                    _films[i] = (Film)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");
                    return;
                }
            }
            Console.WriteLine("Not Found!!");
        }
    }
}

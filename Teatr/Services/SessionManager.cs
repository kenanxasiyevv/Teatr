using Core.Models;
using Core.Services.Contracts;
using Teatr.Models;

namespace Teatr.Services
{
    internal class SessionManager:IPrintService
    {
        private Session[] _sessions = new Session[4];
        private int _sessionCount;

        public void Add(Entity entity)
        {
            if (_sessionCount > 3)
            {
                Console.WriteLine("4 seans movcuddur, basqa elave etmek olmaz");
            }
            _sessions[_sessionCount++] = (Session)entity;
        }
        public Entity Get(int id)
        {

            for (int i = 0; i < _sessions.Length; i++)
            {
                if (_sessions[i] == null)
                    continue;

                if (id == _sessions[i].Id)
                {
                    Console.WriteLine(_sessions[i]);
                    return _sessions[i];
                }
            }
            Console.WriteLine("Not Found!!");
            return null;
        }

        public void Print()
        {
            foreach (var item in _sessions)
            {
                if (item == null)
                    continue;
                Console.WriteLine(item);
            }
        }
    }
}

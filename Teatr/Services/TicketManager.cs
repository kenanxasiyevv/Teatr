using Core.Models;
using Core.Services.Contracts;
using Teatr.Models;

namespace Teatr.Services
{
    internal class TicketManager:IPrintService
    {

        private Ticket[] _tickets = new Ticket[100];
        private int _ticketCount;
        internal int Price { get; set; }

        public void Add(Entity entity)
        {
            if (_ticketCount > 99)
            {
                Console.WriteLine("Bilet bitti! Basqa elave etmek olmaz");
            }
            _tickets[_ticketCount++] = (Ticket)entity;
        }




        public void Print()
        {
            foreach (var item in _tickets)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item.ToString());
            }
        }

        public Entity Get(int id)
        {

            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                    continue;

                if (id == _tickets[i].Id)
                {
                    Console.WriteLine(_tickets[i]);
                    return _tickets[i];
                }
            }
            Console.WriteLine("Not Found!!");
            return null;
        }
    }
}

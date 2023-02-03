using Core.Models;
using Core.Services.Contracts;
using Teatr.Enums;
using Teatr.Models;

namespace Teatr.Services
{
    public class TicketManager : IPrintService
    {

        private Ticket[] _tickets = new Ticket[100];
        private int _ticketCount;
        internal int Price { get; set; }
        
        private readonly SessionManager _sessionManager;
        internal TicketManager(SessionManager sessionManager)
        {
            _sessionManager = sessionManager;

        }

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
                    return _tickets[i];
                }
            }
            Console.WriteLine("Not Found!!");
            return null;
        }

        public void BuyTicket()
        {
            Console.WriteLine("Seans:");
            _sessionManager.Print();

        seans:
            Console.Write("Session id:");
            var sessionId = int.Parse(Console.ReadLine());

            var session = (Session)_sessionManager.Get(sessionId);

            if (sessionId == null || sessionId > 4)
            {
                goto seans;
            }
            Console.WriteLine(session);

            _sessionManager.PrintSessionSeats(session);

        row:
            Console.Write("Row:");
            var row = int.Parse(Console.ReadLine());


            if (!(row >= 1 && row <= session.Seats.GetLength(0)))
            {
                Console.WriteLine("Row is not correct!");

                goto row;
            }

        column:
            Console.Write("Column:");
            var column = int.Parse(Console.ReadLine());

            if (!(column >= 1 && column <= session.Seats.GetLength(1)))
            {
                Console.WriteLine("Column is not correct!");

                goto column;
            }

            if (session.Seats[row - 1, column - 1] == State.Full)
            {
                Console.WriteLine("This seat is not empty!");

                goto row;
            }

            session.Seats[row - 1, column - 1] = State.Full;

            var ticket = new Ticket()
            {
                Session = session,
                Row = row,
                Column = column
            };

            Add(ticket);
            Console.WriteLine("Ticket bought");

        }
    }
}

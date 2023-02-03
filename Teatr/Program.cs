using Teatr.Models;
using Teatr.Services;

namespace Teatr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hallManager = new HallManager();
            var filmManager = new FilmManager();
            var sessionManager = new SessionManager();
            var ticketManager = new TicketManager(sessionManager);

            string command = "";

            var teatr = new Theater()
            {
                Id = 1,
                Name = "CinemaPlus",
            };

            var hall1 = new Hall
            {
                Id = 1,
                Name = "Zal 1",
                Row = 6,
                Column = 5
            };

            var hall2 = new Hall
            {
                Id = 2,
                Name = "Zal 2",
                Row = 8,
                Column = 10
            };

            var hall3 = new Hall
            {
                Id = 3,
                Name = "Zal 3",
                Row = 5,
                Column = 10
            };
            hallManager.Add(hall1);
            hallManager.Add(hall2);
            hallManager.Add(hall3);

            var film1 = new Film()
            {
                Id = 1,
                Name = "Spiderman",
                Director = "Sam Raimi",
                DateofFilm = "30 June 2004"
            };

            var film2 = new Film()
            {
                Id = 2,
                Name = "Avatar",
                Director = "James Cameron",
                DateofFilm = "10 December 2009"
            };

            var film3 = new Film()
            {
                Id = 3,
                Name = "Black Panther",
                Director = "Ryaan Coogler",
                DateofFilm = "15 September 2005"
            };

            var film4 = new Film()
            {
                Id = 4,
                Name = "Green Mile",
                Director = "Frank Darabont",
                DateofFilm = "10 December 1999"
            };
            filmManager.Add(film1);
            filmManager.Add(film2);
            filmManager.Add(film3);
            filmManager.Add(film4);

            var session1 = new Session
            {
                Id = 1,
                Film = film2,
                Hall = hall1,
                Price = 10,
                Teatr = teatr,
                Seats = new Enums.State[6, 5]

            };

            var session2 = new Session
            {
                Id = 2,
                Film = film1,
                Hall = hall2,
                Price = 15,
                Teatr = teatr,
                Seats = new Enums.State[8, 10]
            };

            var session3 = new Session
            {
                Id = 3,
                Film = film3,
                Hall = hall3,
                Price = 13,
                Teatr = teatr,
                Seats = new Enums.State[5, 10]
            };

            var session4 = new Session()
            {
                Id = 4,
                Film = film1,
                Hall = hall3,
                Price = 14,
                Teatr = teatr,
                Seats = new Enums.State[5, 10]

            };
            sessionManager.Add(session1); ;
            sessionManager.Add(session2); ;
            sessionManager.Add(session3); ;
            sessionManager.Add(session4); ;

            do
            {
                Console.Write("Enter Command: ");
                command = Console.ReadLine();

                if (command.ToLower().Equals("print halls"))
                {
                    hallManager.Print();
                }

                else if (command.ToLower().Equals("update hall"))
                {
                    Console.Write("Id daxil edin: ");
                    var id = int.Parse(Console.ReadLine());
                    var existHall = hallManager.Get(id);

                    var hall4 = new Hall
                    {
                        Id = 4,
                        Name = "Zal 4",
                        Row = 10,
                        Column = 20
                    };
                    hallManager.Update(id, hall4);
                }

                else if (command.ToLower().Equals("get hall"))
                {
                    Console.Write("ID daxil edin: ");
                    var id = int.Parse(Console.ReadLine());

                    Console.WriteLine(hallManager.Get(id));
                }

                else if (command.ToLower().Equals("show session"))
                {
                    sessionManager.Print();
                }

                else if (command.ToLower().Equals("show films"))
                {
                    filmManager.Print();
                }

                else if (command.ToLower().Equals("delete film"))
                {
                    Console.Write("ID daxil edin: ");
                    int id = int.Parse(Console.ReadLine());

                    filmManager.Delete(id);
                }

                else if (command.ToLower().Equals("update film"))
                {
                    Console.Write("ID daxil edin: ");
                    int id = int.Parse(Console.ReadLine());

                    var film5 = new Film()
                    {
                        Id = 5,
                        Name = "The 100",
                        Director = "Jason Rothenberg",
                        DateofFilm = "19 March 2004"
                    };
                    filmManager.Update(id, film5);
                }

                else if (command.ToLower().Equals("get film"))
                {
                    Console.Write("Id daxil edin: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine(filmManager.Get(id));
                }

                else if (command.ToLower().Equals("buy ticket"))
                {
                    ticketManager.BuyTicket();
                }

                else if(command == "get ticket")
                {
                    Console.Write("Bilet Id-si daxil edin: ");
                    int  id = int.Parse(Console.ReadLine());

                   Console.WriteLine( ticketManager.Get(id));
                }
                else if (command == "show tickets")
                {
                    ticketManager.Print();
                }

            } while (!command.ToLower().Equals("quit"));
        }
    }
}

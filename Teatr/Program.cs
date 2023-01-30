using Teatr.Services;
using Teatr.Models;

namespace Teatr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teater = new Theater();
            var hallManager = new HallManager();
            var filmManager = new FilmManager();
            var ticketManager = new TicketManager();
            var sessionManager = new SessionManager();
            string command = "";

            teater.Name = "CinemaPlus";
            Console.WriteLine(teater.Name);

            var session1 = new Session
            {
                Id = 1,
                DateTime = "12:25",
                Film = "Green Mile",
                Hall = "Zal 1"
            };
            var session2 = new Session
            {
                Id = 2,
                DateTime = "22:30",
                Film = "Black Panther",
                Hall = "Zal 3"
            };
            var session3 = new Session
            {
                Id = 3,
                DateTime = "16:45",
                Film = "Avatar",
                Hall = "Zal 2"
            };
            var session4 = new Session()
            {
                Id = 4,
                DateTime = "19:05",
                Film = "Spiderman",
                Hall = "Zal 4"
            };
            sessionManager.Add(session1); ;
            sessionManager.Add(session2); ;
            sessionManager.Add(session3); ;
            sessionManager.Add(session4); ;

            var hall1 = new Hall
            {
                Id = 1,
                Name = "Zal 1",
                raw = 10,
                column = 20
            };
            var hall2 = new Hall
            {
                Id = 2,
                Name = "Zal 2",
                raw = 10,
                column = 20
            };
            var hall3 = new Hall
            {
                Id = 3,
                Name = "Zal 3",
                raw = 10,
                column = 20
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
            do
            {
                Console.Write("Enter Command: ");
                command = Console.ReadLine();

                if (command.ToLower().Equals("print hall"))
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
                        raw = 10,
                        column = 20
                    };
                    hallManager.Update(id, hall4);
                }
                else if (command.ToLower().Equals("get hall"))
                {
                    Console.Write("ID daxil edin: ");
                    var id = int.Parse(Console.ReadLine());

                    hallManager.Get(id);
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

                    filmManager.Get(id);
                }
                else if (command.ToLower().Equals("add ticket"))
                {
                    var ticket = new Ticket();
                    sessionManager.Print();
                    Console.Write("Hansi id-li seansi almaq isteyirsiniz: ");
                    int id = int.Parse(Console.ReadLine());
                    sessionManager.Get(id);

                    string[,] place = new string[10, 20];
                    ticket.Id = 1;
                    ticket.Price = 9;

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            place[i, j] = "Empty";
                            Console.Write($"{place[i, j]}" + " ");

                        }
                    }
                    Console.WriteLine();

                    Console.Write("Hansi sirada oturmaq isteyirsiniz: ");
                    int row = int.Parse(Console.ReadLine());
                    Console.Write("Hansi yerde oturmaq isteyirsiniz: ");
                    int column = int.Parse(Console.ReadLine());
                    place[row - 1, column - 1] = "Full";

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            Console.Write($"{place[i, j]}" + " ");
                        }
                    }
                    Console.WriteLine();

                    ticketManager.Add(ticket);
                    ticketManager.Get(1);
                    Console.WriteLine("Bilet Ugurla Alindi!!");

                }
            } while (!command.ToLower().Equals("quit"));
        }
    }
}
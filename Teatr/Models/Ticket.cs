using Core.Models;
namespace Teatr.Models
{
    internal class Ticket : Entity
    {
        private static int _id;
        public Session Session { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public Ticket() : base(++_id) { }

        public override string ToString()
        {
            return $"{Session}\n{Row}x{Column}";
        }
    }
}

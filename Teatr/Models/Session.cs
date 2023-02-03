using Core.Models;
using Teatr.Enums;

namespace Teatr.Models
{
    internal class Session : Entity
    {
        public Film Film { get; set; }
        public Hall Hall { get; set; }
        public State[,] Seats { get; set; }
        public double Price { get; set; }

        public Theater Teatr { get; set; }

        public override string ToString()
        {
            return $"{"SessionID:",-4} {Id}\n{"Theater: ",-4}{Teatr.Name}\n{"Film:",-4}\n{Film}{"Hall:"}\n{Hall}{"Price:",-4}{Price:C}\n\n";
        }
    }
}

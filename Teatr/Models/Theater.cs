using Core.Models;


namespace Teatr.Models
{
    internal class Theater:Entity
    {
        internal Hall[] _halls = new Hall[3];
        internal string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\tName: {Name}";
        }
    }
}

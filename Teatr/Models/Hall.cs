using Core.Models;
namespace Teatr.Models
{
    internal class Hall : Entity
    {
        internal string Name { get; set; }
        internal int Row { get; set; }
        internal int Column { get; set; }

        public override string ToString()
        {
            return $"{"ID:",-4} {Id}\n{"Zal adi:",-6} {Name}\n{"Zal olcusu:",-6}{Row} x {Column}\n{"Tutumu:", -6} {Row * Column} nefer\n";
        }

    }
}

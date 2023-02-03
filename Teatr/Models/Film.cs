using Core.Models;
namespace Teatr.Models
{
    internal class Film : Entity
    {
        internal string Name { get; set; }
        internal string Director { get; set; }
        internal string DateofFilm { get; set; }

        public override string ToString()
        {
            return $"{"Id:", -2} {Id}\n{"Filmin adi:", -6} {Name}\n{"Filmin Rejissoru:",-6} {Director}\n{"Filmin cixma tarixi:",-6}{DateofFilm}\n\n";
        }
    }
}

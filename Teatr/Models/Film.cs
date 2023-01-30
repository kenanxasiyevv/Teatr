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
            return $"{Id} Filmin adi:{Name}\nFilmin Rejissoru:{Director}\nFilmin cixma tarixi:{DateofFilm}\n\n";
        }
    }
}

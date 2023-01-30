using Core.Models;
namespace Teatr.Models
{
    internal class Session : Entity
    {
        internal string DateTime { get; set; }
        internal string Hall { get; set; }
        internal string Film { get; set; }

        public override string ToString()
        {
            return $"{Id} Film--{Film}\nZal--{Hall}\nZamani--{DateTime}";
        }
    }
}

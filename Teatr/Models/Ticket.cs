using Core.Models;
namespace Teatr.Models
{
    internal class Ticket : Entity
    {
        internal Session[] sessions = new Session[4];
        internal decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} _-_-_-_-Bilet Sayi: {1}_-_-_-_-Bilet qiymeti:{Price}";
        }
    }
}

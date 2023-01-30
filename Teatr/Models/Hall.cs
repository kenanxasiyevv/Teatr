using Core.Models;
namespace Teatr.Models
{
    internal class Hall:Entity
    {
        internal string Name { get; set; }
        internal int raw { get; set; }
        internal int column { get; set; }


        public override string ToString()
        {
            return $"{Id} Zal adi: {Name}\nZal olcusu:{raw} x {column}\nTutumu {raw * column} nefer\n";
        }

    }
}

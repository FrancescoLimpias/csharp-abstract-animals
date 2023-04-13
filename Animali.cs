using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Cane : Animale
    {

        public Cane(string nome) : base("Cane", nome)
        { }

        //Abstract class implementations
        public override void Verso()
        {
            Console.Write("abbàio");
        }
        public override void Mangia()
        {
            Console.Write("carne, verdure");
        }
    }

    internal class Passerotto : Animale
    {
        public Passerotto(string nome) : base("Passerotto", nome)
        { }

        //Abstract class implementations
        public override void Verso()
        {
            Console.Write("cinguettio");
        }
        public override void Mangia()
        {
            Console.Write("semi, vermi");
        }
    }

    internal class Aquila : Animale
    {
        public Aquila(string nome) : base("Aquila", nome)
        { }

        //Abstract class implementations
        public override void Verso()
        {
            Console.Write("stridulo");
        }
        public override void Mangia()
        {
            Console.Write("carne");
        }
    }

    internal class Delfino : Animale
    {
        public Delfino(string nome) : base("Delfino", nome)
        { }

        //Abstract class implementations
        public override void Verso()
        {
            Console.Write("biosonar");
        }
        public override void Mangia()
        {
            Console.Write("pesce");
        }
    }
}

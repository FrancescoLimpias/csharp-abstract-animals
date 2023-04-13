using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Cane : Animale
    {
        //Abstract class implementations
        public override void Verso()
        {
            Console.Write("l'abbàio");
        }
        public override void Mangia()
        {
            Console.Write("carne, verdure");
        }
    }

    internal class Passerotto : Animale
    {
        //Abstract class implementations
        public override void Verso()
        {
            Console.Write("il cinguettio");
        }
        public override void Mangia()
        {
            Console.Write("semi, vermi");
        }
    }

    internal class Aquila : Animale
    {
        //Abstract class implementations
        public override void Verso()
        {
            Console.Write("lo stridulo");
        }
        public override void Mangia()
        {
            Console.Write("carne");
        }
    }

    internal class Delfino : Animale
    {
        //Abstract class implementations
        public override void Verso()
        {
            Console.Write("il biosonar");
        }
        public override void Mangia()
        {
            Console.Write("pesce");
        }
    }
}

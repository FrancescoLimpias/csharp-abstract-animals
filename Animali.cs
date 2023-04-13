using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Cane : Animale
    {

        public Cane(string nome) : base("Cane", nome, Dieta.Onnivoro)
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

    internal class Passerotto : Animale, IVolante
    {
        public Passerotto(string nome) : base("Passerotto", nome, Dieta.Onnivoro)
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

    internal class Aquila : Animale, IVolante
    {
        public Aquila(string nome) : base("Aquila", nome, Dieta.Carnivoro)
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

    internal class Delfino : Animale, INuotante
    {
        public Delfino(string nome) : base("Delfino", nome, Dieta.Carnivoro)
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

    internal class Mucca : Animale
    {
        public Mucca(string nome) : base("Mucca", nome, Dieta.Erbivoro)
        { }

        //Abstract class implementations
        public override void Verso()
        {
            Console.Write("muggito");
        }
        public override void Mangia()
        {
            Console.Write("erba, fieno, bacche");
        }
    }
}

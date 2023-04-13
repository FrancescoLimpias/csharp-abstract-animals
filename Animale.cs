using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal abstract class Animale
    {

        /* "Dormi" Function
         * it is common to all animals
         */
        public void Dormi()
        {
            Console.WriteLine("Zzz");
        }

        /* "Verso" Function
         * it's specific to each animal
         */
        public abstract void Verso();

        /* "Mangia" Function
         */
        public abstract void Mangia();

    }
}

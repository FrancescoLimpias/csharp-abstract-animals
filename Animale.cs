using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{ 
    public enum Dieta
    { 
        Erbivoro,
        Carnivoro,
        Onnivoro
    }
    internal abstract class Animale
    {
        //The animal's names
        public string Specie { get; private set; }
        public string Nome { get; private set; }
        public string NomeCompleto => $"{Specie} {Nome}";
        public Dieta Dieta { get; private set; }

        public Animale(string specie, string nome, Dieta dieta)
        {
            Specie = specie;
            Nome = nome;
            Dieta = dieta;
        }

        /* "Dormi" Function
         * it is common to all animals
         */
        public void Dormi()
        {
            Console.Write("Zzz");
        }

        /* "Verso" Function
         * it's specific to each animal
         */
        public abstract void Verso();

        /* "Mangia" Function
         */
        public abstract void Mangia();

        //Printing function
        public void Print()
        {
            // Print animal name
            Console.WriteLine($"Animale: {NomeCompleto}");

            // Print animal sound
            Console.Write("Verso: ");
            Verso();
            Console.WriteLine();

            // Print animal foods
            Console.Write("Dieta: ");
            Mangia();
            Console.WriteLine();
        }

    }
}

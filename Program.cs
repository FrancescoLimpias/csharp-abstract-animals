namespace csharp_abstract_animals
{
    internal class Program
    {

        static List<Animale> animali = new List<Animale>();
        static void Main(string[] args)
        {
            animali.Add(new Cane("lupo"));
            animali.Add(new Passerotto("domestico"));
            animali.Add(new Aquila("reale"));
            animali.Add(new Delfino("striato"));
            animali.Add(new Mucca("comune"));

            foreach (Animale animale in animali)
            {

                // Print animal name
                Console.WriteLine($"Animale: {animale.NomeCompleto}");

                /* ****************************
                 * PRIMO ESERCIZIO
                 * ****************************
                 */
                // Print animal sound
                Console.Write("Verso: ");
                animale.Verso();
                Console.WriteLine();

                // Print animal foods
                Console.Write($"Dieta: [{animale.Dieta}] ");
                animale.Mangia();
                Console.WriteLine();

                // Print animal while sleeping
                Console.Write("Dorme: ");
                animale.Dormi();
                Console.WriteLine();

                /* ****************************
                 * SECONDO ESERCIZIO
                 * ****************************
                 */
                //Check if animal flies
                if (animale is IVolante)
                    FaiVolare((IVolante) animale);

                //Check if animal swims
                if (animale is INuotante)
                    FaiNuotare((INuotante) animale);


                Console.WriteLine("-------------");
            }
        }

        //Methods for interfaces (IVolante, INuotante) testing
        static void FaiVolare(IVolante volante)
        {
            volante.Vola();
        }
        static void FaiNuotare(INuotante nuotante)
        {
            nuotante.Nuota();
        }
    }
}
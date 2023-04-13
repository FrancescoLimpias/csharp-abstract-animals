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

            foreach (Animale animale in animali)
            {
                animale.Print();
                Console.WriteLine("-------------");
            }
        }
    }
}
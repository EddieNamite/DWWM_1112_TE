namespace anneeBissextile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A;

            Console.WriteLine("Saisir l'annee A :");
            A = Convert.ToDouble(Console.ReadLine());

            if (((A % 4 == 0) && (A % 100 != 0)) || (A % 400 == 0))
            {
                Console.WriteLine("L'annee " + A + " est bissextile");
            }

            else
            {
                Console.WriteLine("L'annee " + A + " n'est pas bissextile");
            }












        }
    }
}
using System.Net.Security;

namespace calculinterets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somme, interet, nbannee, resultat, result;
            
            Console.WriteLine("Saisissez le montant");
            somme = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Saisissez le nombre d'annees");
            nbannee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Saisissez le taux d'intérêt");
            interet = Convert.ToDouble(Console.ReadLine());

            result = somme * ( 1 + nbannee * ( interet / 100));

            Console.WriteLine("Le resultat pendant " + nbannee + " ans avec un taux d'intérêt simple de " + interet + " sera egale à " + result);

            resultat = somme * Math.Pow (1 + ( interet / 100 ), nbannee);

            Console.WriteLine("Le resultat pendant " + nbannee + " ans avec un taux d'intérêt compose de " + interet + " sera egale à " + Math.Round(resultat * 100) / 100);
        }
    }
}
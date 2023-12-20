namespace moyenneNombreCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcul de la moyenne de 2 nombres");

            double nombre1, nombre2, moyenne;

            Console.WriteLine("Entrez le premier nombre :");
            nombre1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez le deuxième nombre :");
            nombre2 = Convert.ToDouble(Console.ReadLine());

            moyenne = (nombre1 + nombre2) / 2;

            Console.WriteLine("La moyenne des deux nombres est :" + moyenne);
        }
    }
}
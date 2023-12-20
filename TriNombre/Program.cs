namespace TriNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            // Génération des nombres aléatoires

            var r = new Random();
            a = r.Next(0,100);
           
            b = r.Next(0, 100);

            // tri des nombres

            if (a == b)
            {
                Console.WriteLine("Le nombre " + a + " est égal à " + b);
            }
            
            else

            if (a < b)
            {
                Console.WriteLine("Le nombre " + a + " est plus petit que " + b);
            }

            else

            {
                Console.WriteLine("Le nombre " + b + " est plus petit que " + a);
            }
        }
    }
}
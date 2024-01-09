namespace Fourchette08012024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre = 0;
            int essais = 0;
            int sup = 100;
            int min = 0;

            Random rd = new Random();
            int nombreSecret = rd.Next(0,101);
            
            Console.WriteLine("JEU DE LA FOURCHETTE");

            while(nombre != nombreSecret)
            {
                Console.WriteLine("Entrez un nombre entre " + min + " et "  + sup );
                nombre = int.Parse(Console.ReadLine());

                Console.WriteLine(nombre);
                essais++;
                
                // Comparaison des nombres

                if (nombre == nombreSecret)
                {
                 
                    Console.WriteLine("Bravo !! Trouvé en " + essais + " essais !");
                }

                if (nombre < nombreSecret)
                {
                    min = nombre;
                    Console.WriteLine("Trop petit !! entrez un nombre entre " + min + " et " + sup);
                }

                if (nombre > nombreSecret)
                {
                    sup = nombre;
                    Console.WriteLine("Trop grand !! entrez un nombre entre " + min + " et " + sup);
                }

            }
        }
    }
}
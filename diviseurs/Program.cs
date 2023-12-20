namespace diviseurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nb;
            int boucle;
            Console.WriteLine("Saisir un nombre :");
            Nb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liste des diviseurs de " + Nb);

            for (boucle = 2; boucle <= Nb - 1; boucle++)
            {

                if (Nb % boucle == 0)
                {

                    Console.WriteLine(" " + boucle);
                }
            }
        }
    }
}
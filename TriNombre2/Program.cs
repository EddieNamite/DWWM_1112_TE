using System;

namespace TriNombre2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nombrea, nombreb, nombrec;

            // Saisie des nombres

            Console.WriteLine("Saisissez le premier nombre");
            nombrea = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Saisissez le deuxième nombre");
            nombreb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Saisissez le troisième nombre");
            nombrec = Convert.ToDouble(Console.ReadLine());

            // Tri des nombres

            if (nombrec < nombreb && nombrec < nombrea)
            {
                if (nombrea < nombreb)
                {
                    Console.WriteLine("Nombres organisés : " + nombrec + " " + nombrea + " " + nombreb);
                }
                else
                {
                    Console.WriteLine("Nombres organisés : " + nombrec + " " + nombreb + " " + nombrea);
                }
            }
            else if (nombrea < nombreb)
            {
                if (nombreb < nombrec)
                {
                    Console.WriteLine("Nombres organisés : " + nombrea + " " + nombreb + " " + nombrec);

                }
                else
                {
                    Console.WriteLine("Nombres organisés : " + nombrea + " " + nombrec + " " + nombreb);
                }

            }
            else
            {
                if (nombrea < nombrec)
                {
                    Console.WriteLine("Nombres organisés : " + nombreb + " " + nombrea + " " + nombrec);
                }

                else
                {
                    Console.WriteLine("Nombres organisés : " + nombreb + " " + nombrec + " " + nombrea);
                }

            }
        }
    }

}
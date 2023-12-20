namespace inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            
            Console.WriteLine("Saisissez le nombre a :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Saisissez le nombre b :");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nombre a : " + a);
            Console.WriteLine("Nombre b : " + b);

            // inversion des valeurs

            Console.WriteLine("Nombre a : " + b);
            Console.WriteLine("Nombre b : " + a);

            Console.WriteLine("Nombre a : " + a);
            Console.WriteLine("Nombre b : " + b);
        }
    }
}
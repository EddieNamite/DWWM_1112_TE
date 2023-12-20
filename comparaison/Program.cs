namespace comparaison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age;
            
            Console.WriteLine("Bonjour, saisissez votre age : ");
            age = Convert.ToDouble(Console.ReadLine());

            if (age < 1)
                Console.WriteLine("Vous n' etes pas encore ne");
            if (age >0 && age < 18)
                Console.WriteLine("Vous etes mineur");
            if (age > 17)
                Console.WriteLine("Vous etes majeur");
        }
    }
}
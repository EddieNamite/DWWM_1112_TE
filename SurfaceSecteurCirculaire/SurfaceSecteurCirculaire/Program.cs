namespace SurfaceSecteurCirculaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon, angle, aire;

            Console.WriteLine("Calcul de la surface d'un secteur circulaire :");
            
            Console.WriteLine("Saisissez le rayon :");
            rayon = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Saisissez l'angle");
            angle = Convert.ToDouble(Console.ReadLine());   

            aire = Math.Round(Math.PI * (Math.Pow(rayon, 2) * angle) / 360);
        
            Console.WriteLine("La surface du secteur circulaire est de : " + aire);
        }
    }
}
namespace aireVolumeSphere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon, volume, aire;
            
            Console.WriteLine("Calcul de l'aire et du volume d'une sphere");
            Console.WriteLine("Saisissez le rayon :");
            rayon = Convert.ToDouble(Console.ReadLine());

            aire = Math.Round (4 * Math.PI * (rayon * rayon) *100)/100;
            volume = Math.Round(4 / 3 * Math.PI * Math.Pow(rayon, 3) * 100) /100;
            Console.WriteLine("L'aire de la sphère est : " + aire + " et le volume est " + volume);       
        }
    }
}
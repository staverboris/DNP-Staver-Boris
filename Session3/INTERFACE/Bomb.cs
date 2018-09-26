namespace INTERFACE
{
    public class Bomb : IExplodable<double>
    {
        public void Explode(double radius)
        {
       System.Console.WriteLine("Boom!"+radius);        }
    }
}


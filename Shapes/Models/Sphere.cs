using System;

namespace Shapes.Models
{
    public class Sphere 
    {
        public Circle Surface { get; set; }

        public Sphere (Circle surface)
        {
            Surface = surface;
        }

        public double GetVolume()
        {
            double radiusCubed = Math.Pow(Surface.Radius, 3);
            double fraction = (double) 4 /3;
            return Math.PI * radiusCubed * fraction;
        }


        public double GetSurfaceArea()
        {
            double radiusSquared = Math.Pow(Surface.Radius, 2);
            return Math.PI * 4 * radiusSquared;
        }
    }
}
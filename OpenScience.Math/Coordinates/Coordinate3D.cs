namespace OpenScience.Math.Coordinates
{
    public class Coordinate3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Coordinate3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Coordinate3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceFrom(Coordinate3D otherPoint)
        {
            var distanceX = System.Math.Pow(X - otherPoint.X, 2);
            var distanceY = System.Math.Pow(Y - otherPoint.Y, 2);
            var distanceZ = System.Math.Pow(Z - otherPoint.Z, 2);
            return System.Math.Sqrt(distanceX + distanceY + distanceZ);
        }

    }
}

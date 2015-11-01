using OpenScience.Math.Units;

namespace OpenScience.Math.Coordinates
{
    public class PhysicalCoordinate<TLength>
        where TLength : NumericValue<Length>, new()
    {
        public TLength X { get; set; }
        public TLength Y { get; set; }
        public TLength Z { get; set; }

        public PhysicalCoordinate()
        {
            X = new TLength { Value = 0 };
            Y = new TLength { Value = 0 };
            Z = new TLength { Value = 0 };
        }

        public PhysicalCoordinate(TLength x, TLength y, TLength z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public TLength DistanceFrom<TOtherLength>(PhysicalCoordinate<TOtherLength> otherPoint)
            where TOtherLength : NumericValue<Length>, new()
        {
            var distanceX = System.Math.Pow((X - otherPoint.X).Value, 2);
            var distanceY = System.Math.Pow((Y - otherPoint.Y).Value, 2);
            var distanceZ = System.Math.Pow((Z - otherPoint.Z).Value, 2);
            return new TLength { Value = System.Math.Sqrt(distanceX + distanceY + distanceZ) };
        }
    }
}

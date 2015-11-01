namespace OpenScience.Math.Units.MassMeasures
{
    public class AtomicMassUnit : NumericValue<Mass>
    {
        public AtomicMassUnit(){}
        public AtomicMassUnit(double value):base(value){}
        public override double ConversionFactor { get { return (6.02214129*System.Math.Pow(10,26)); } }
        public override string Abbreviation { get { return "u"; } }
    }
}

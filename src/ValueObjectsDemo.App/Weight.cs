namespace ValueObjectsDemo.App
{
    public class Weight
    {
        public double Value { get; }

        public Weight(double value)
        {
            Value = value;
        }

        public double Kilograms => Value / 1000;

        public Weight Add(double value) => new(Value + value);
    }
}

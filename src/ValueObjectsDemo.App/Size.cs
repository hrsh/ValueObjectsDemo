namespace ValueObjectsDemo.App
{
    public class Size
    {
        public double ShoeSize { get; }

        public Size(double shoeSize) =>
            ShoeSize = shoeSize;
    }

    public record Price(int Amount, int Discount);
}
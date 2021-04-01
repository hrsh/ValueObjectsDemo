namespace ValueObjectsDemo.App
{
    public class Shoe
    {
        public Shoe(int id, Price price, Size size)
        {
            Id = id;
            Price = price;
            Size = size;
        }

        public int Id { get; set; }

        public Price Price { get; set; }
        
        public Size Size { get; set; }
    }
}
namespace ValueObjectsDemo.App
{
    public class Size
    {
        public Dimension H { get; }

        public Dimension W { get; }

        public Dimension L { get; }

        public Size(Dimension h, Dimension w, Dimension l)
        {
            H = h;
            W = w;
            L = l;
        }
    }
}

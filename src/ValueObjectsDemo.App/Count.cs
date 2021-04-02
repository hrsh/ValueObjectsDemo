namespace ValueObjectsDemo.App
{
    public class Count
    {
        public int Value { get; private set; }

        public Count(int value)
        {
            Value = value;
        }

        public void ChangeCount(int count)
        {
            Value = count;
        }
    }
}

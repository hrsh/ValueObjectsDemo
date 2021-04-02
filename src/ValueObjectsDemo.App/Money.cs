namespace ValueObjectsDemo.App
{
    public class Money
    {
        public int Value { get; private set; }

        public Money(int value)
        {
            Value = value;
        }

        public void ChangeMoney(int value) => Value = value;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectsDemo.App
{
    public class Dimension : ValueObject
    {
        public int Value { get; }

        public Dimension(int value)
        {
            Value = value;
        }

        public static bool operator ==(Dimension d1, Dimension d2) =>
            d1.Value == d2.Value;

        public static bool operator !=(Dimension d1, Dimension d2) =>
            d1.Value != d2.Value;

        public static Dimension operator +(Dimension d1, Dimension d2) =>
            new(d1.Value + d2.Value);

        public static bool operator ==(Dimension d1, int value) =>
            d1.Value == value;

        public static bool operator !=(Dimension d1, int value) =>
            d1.Value != value;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is null)
            {
                return false;
            }

            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                throw new ArgumentException($"Invalid comparison of Value Objects of different types: {GetType()} and {obj.GetType()}");
            var valueObject = (ValueObject)obj;
            return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}

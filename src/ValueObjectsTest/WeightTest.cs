using ValueObjectsDemo.App;
using Xunit;

namespace ValueObjectsTest
{
    public class WeightTest
    {
        [Fact]
        public void TestWeight()
        {
            var w1 = new Weight(1500);
            var w2 = w1.Add(500);

            Assert.False(w1 == w2);
            Assert.True(w1.Value == 1500);
            Assert.True(w1.Kilograms == 1.5);
            Assert.True(w2.Value == 2000);
        }
    }
}

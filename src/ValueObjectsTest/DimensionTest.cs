using ValueObjectsDemo.App;
using Xunit;

namespace ValueObjectsTest
{
    public class DimensionTest
    {
        [Fact]
        public void DimensionsAreEqualTest()
        {
            var d1 = new Dimension(12);
            var d2 = new Dimension(12);

            var d3 = d1 + d2;

            Assert.True(d1 == d2);
            Assert.True(d3 == d1 + d2);
        }
    }
}

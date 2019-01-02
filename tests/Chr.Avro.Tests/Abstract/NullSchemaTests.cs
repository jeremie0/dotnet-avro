using Chr.Avro.Abstract;
using Xunit;

namespace Chr.Avro.Tests
{
    public class NullSchemaTests
    {
        [Fact]
        public void IsPrimitiveSchema()
        {
            Assert.IsAssignableFrom<PrimitiveSchema>(new NullSchema());
        }
    }
}

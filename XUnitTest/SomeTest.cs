using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

using SomeLib;

namespace XUnitTest
{
    public class SomeTest
    {
        [Fact]
        public void TestMethod()
        {
            SomeClass foo = new SomeClass();

            Assert.Equal("aaaa", foo.getBar());
        }
    }
}

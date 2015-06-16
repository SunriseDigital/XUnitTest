using System;
using System.Collections.Generic;
using System.Text;

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
            Assert.Equal("hoge", foo.getBar());
        }
    }
}

﻿using System;
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
            Assert.Equal("bar", foo.getBar());
            Console.WriteLine("Console. hogehoge");
        }

        [Fact]
        public void 日本語のメソッド()
        {
            SomeClass foo = new SomeClass();
            Assert.Equal("bar", foo.getBar());
            Console.WriteLine("Console. hogehoge");
        }
    }
}

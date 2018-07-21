using System;
using Xunit;
using IsogramProblem;

namespace Isogram.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, checkisogram.IsIsogram(""));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(1, checkisogram.IsIsogram("isogram"));
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal(0, checkisogram.IsIsogram("eleven"));
        }
        [Fact]
        public void Test4()
        {
            Assert.Equal(1, checkisogram.IsIsogram("subdermatoglyphic"));
        }
        [Fact]
        public void Test5()
        {
            Assert.Equal(1, checkisogram.IsIsogram("Alphabet"));
        }
        [Fact]
        public void Test6()
        {
            Assert.Equal(1, checkisogram.IsIsogram("thumbscrew-japingly"));
        }
        [Fact]
        public void Test7()
        {
            Assert.Equal(1, checkisogram.IsIsogram("six-year-old"));
        }
        [Fact]
        public void Test8()
        {
            Assert.Equal(0, checkisogram.IsIsogram("Nikita"));
        }

    }
}

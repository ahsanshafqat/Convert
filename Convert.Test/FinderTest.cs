using Finder;
using NUnit.Framework;
using System;
using System.Numerics;

namespace Finder.Test
{
    [TestFixture]
    public class FinderTest
    {

        [Test]
        public void Test_Find_Lower_Letter_And_ResultFound_Count_Returned()
        {
            var coverter = new ValueFinder();

            int counter = coverter.Search<string, string>("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.", "e");

            Assert.AreEqual(10, counter);
        }

        [Test]
        public void Test_Find_Upper_Letter_And_ResultFound_Count_Returned()
        {
            var coverter = new ValueFinder();

            int counter = coverter.Search<string, string>("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.", "E");

            Assert.AreEqual(2, counter);
        }

        [Test]
        public void Test_Find_Letter_And_Result_Not_Found_Count_Returned()
        {
            var coverter = new ValueFinder();

            int counter = coverter.Search<string, string>("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.", "Z");

            Assert.AreEqual(0, counter);
        }

        [Test]
        public void Test_Find_BigInt_And_ResultFound_Count_Returned()
        {
            var coverter = new ValueFinder();

            int counter = coverter.Search<BigInteger, int>(BigInteger.Parse("17272838119191929838299111"), 1);

            Assert.AreEqual(8, counter);
        }

        [Test]
        public void Test_Find_BigInt_And_Result_Not_Found_Count_Returned()
        {
            var coverter = new ValueFinder();

            int counter = coverter.Search<BigInteger, int>(BigInteger.Parse("17272838119191929838299111"), 5);

            Assert.AreEqual(0, counter);
        }

        [Test]
        public void Test_Find_Emtpy_Value_Throw_Argument_Exception()
        {
            var coverter = new ValueFinder();

            var ex = Assert.Throws<ArgumentException>(() => coverter.Search<string, string>(string.Empty, "e"));

            Assert.AreEqual("value cannot be empty", ex.Message);
        }

        [Test]
        public void Test_Find_Emtpy__SearchValue_Throw_Argument_Exception()
        {
            var coverter = new ValueFinder();

            var ex = Assert.Throws<ArgumentException>(() => coverter.Search<string, string>("asdasdasdasdasd", string.Empty));

            Assert.AreEqual("seach value cannot be empty", ex.Message);

        }
    }
}

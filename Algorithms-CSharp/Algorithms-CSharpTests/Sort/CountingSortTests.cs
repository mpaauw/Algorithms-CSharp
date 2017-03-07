using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms_CSharp.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_CSharp.Shared;

namespace Algorithms_CSharp.Sort.Tests
{
    [TestClass]
    public class CountingSortTests
    {
        private const int TEST_BREADTH = 200;

        private const int TEST_DEPTH = 50000;

        private TestEngine testDriver;

        private CountingSort countingSort;

        public CountingSortTests()
        {
            this.testDriver = new TestEngine(TEST_BREADTH, TEST_DEPTH);
            this.countingSort = new CountingSort();
        }

        [TestMethod]
        public void sortTest()
        {
            // act / assert
            int[] actualSort = this.countingSort.sort(this.testDriver.elements);
            Array.Sort(this.testDriver.elements);
            int[] expectedSort = this.testDriver.elements;
            for(int i = 0; i < actualSort.Length; i++)
            {
                Assert.AreEqual(expectedSort[i], actualSort[i]);
            }
        }
    }
}
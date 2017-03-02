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
    public class MergeSortTests
    {
        private const int TEST_BREADTH = 20;

        private const int TEST_DEPTH = 100;

        private TestEngine testDriver;

        private MergeSort mergeSort;

        public MergeSortTests()
        {
            this.testDriver = new TestEngine(TEST_BREADTH, TEST_DEPTH);
            this.mergeSort = new MergeSort();
        }

        [TestMethod]
        public void sortTest()
        {
            int[] actualSort = this.mergeSort.sort(this.testDriver.elements);
            Array.Sort(this.testDriver.elements);
            int[] expectedSort = this.testDriver.elements;
            for(int i = 0; i < actualSort.Length; i++)
            {
                Assert.AreEqual(expectedSort[i], actualSort[i]);
            }
        }
    }
}
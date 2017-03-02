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
    /// <summary>
    /// Unit test class that tests methods within the MergeSort class.
    /// </summary>
    [TestClass]
    public class MergeSortTests
    {
        private const int TEST_BREADTH = 200;

        private const int TEST_DEPTH = 10000;

        private TestEngine testDriver;

        private MergeSort mergeSort;

        /// <summary>
        /// Default constructor.
        /// Initializes all class-wide test-dependent members.
        /// </summary>
        public MergeSortTests()
        {
            this.testDriver = new TestEngine(TEST_BREADTH, TEST_DEPTH);
            this.mergeSort = new MergeSort();
        }

        /// <summary>
        /// Tests if the sort() method within the MergeSort class is able to properly sort an array of items.
        /// </summary>
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
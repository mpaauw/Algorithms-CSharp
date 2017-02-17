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
    /// Unit test class that tests methods within the SelectionSort class.
    /// </summary>
    [TestClass]
    public class SelectionSortTests
    {
        private const int TEST_BREADTH = 200;

        private const int TEST_DEPTH = 50000;

        private TestEngine testDriver;

        private SelectionSort<int> selectionSort;
    
        /// <summary>
        /// Default constructor.
        /// Initializes all class-wide test-dependent members.
        /// </summary>
        public SelectionSortTests()
        {
            this.testDriver = new TestEngine(TEST_BREADTH, TEST_DEPTH);
            selectionSort = new SelectionSort<int>();
        }

        /// <summary>
        /// Tests if the sort() method within the SelectionSort class is able to properly sort an array of items.
        /// </summary>
        [TestMethod]
        public void sortTest()
        {
            // arrange
            IComparable[] unsortedArray = new IComparable[this.testDriver.elements.Length];
            for(int i = 0; i < this.testDriver.elements.Length; i++)
            {
                unsortedArray[i] = this.testDriver.elements[i];
            }
            Array.Sort(this.testDriver.elements);
            int[] expectedSort = this.testDriver.elements;
            // act
            IComparable[] actualSort = selectionSort.sort(unsortedArray);
            // assert
            for(int i = 0; i < actualSort.Length; i++)
            {
                Assert.Equals(actualSort[i].CompareTo(expectedSort[i]), 0);
            }
        }
    }
}
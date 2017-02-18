using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms_CSharp.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_CSharp.Shared;

namespace Algorithms_CSharp.Search.Tests
{
    /// <summary>
    /// Unit test class that tests methods within the BinarySearch class.
    /// </summary>
    [TestClass]
    public class BinarySearchTests
    {
        private const int TEST_BREADTH = 50;

        private const int TEST_DEPTH = 1500;

        private TestEngine testDriver;

        private BinarySearch binarySearch;

        public BinarySearchTests()
        {
            this.testDriver = new TestEngine(TEST_BREADTH, TEST_DEPTH);
            this.binarySearch = new BinarySearch();
        }

        /// <summary>
        /// Tests if the search() method within the BinarySearch class is able to properly search for items within a sorted array.
        /// </summary>
        [TestMethod]
        public void searchTest()
        {
            // arrange
            Array.Sort(this.testDriver.elements);
            int existingIndex = this.testDriver.generateRandomElementBound(this.testDriver.elements.Length);
            int existingElement = this.testDriver.elements[existingIndex];
            int nonExistentElement;
            do
            {
                nonExistentElement = this.testDriver.generateRandomElementBound(TEST_DEPTH);
            } while (this.testDriver.elements.Contains(nonExistentElement));
            // act
            bool shouldContain = this.binarySearch.search(this.testDriver.elements, existingElement, 0, this.testDriver.elements.Length);
            bool shouldNotContain = this.binarySearch.search(this.testDriver.elements, nonExistentElement, 0, this.testDriver.elements.Length);
            // assert
            Assert.IsTrue(shouldContain);
            Assert.IsFalse(shouldNotContain);
        }
    }
}
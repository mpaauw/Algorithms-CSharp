﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    /// Unit test class that tests methods within the InsertionSort class.
    /// </summary>
    [TestClass]
    public class InsertionSortTests
    {
        private const int TEST_BREADTH = 200;

        private const int TEST_DEPTH = 50000;

        private TestEngine testDriver;

        private InsertionSort insertionSort;

        /// <summary>
        /// Default constructor.
        /// Initializes all class-wide test-dependent members.
        /// </summary>
        public InsertionSortTests()
        {
            this.testDriver = new TestEngine(TEST_BREADTH, TEST_DEPTH);
            this.insertionSort = new InsertionSort();
        }

        /// <summary>
        /// Tests if the sort() method within the SelectionSort class is able to properly sort an array of items.
        /// </summary>
        [TestMethod]
        public void sortTest()
        {
            // act / assert
            int[] actualSort = this.insertionSort.sort(this.testDriver.elements);
            Array.Sort(this.testDriver.elements);
            int[] expectedSort = this.testDriver.elements;
            for (int i = 0; i < actualSort.Length; i++)
            {
                Assert.AreEqual(expectedSort[i], actualSort[i]);
            }
        }
    }
}
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TechnicalTests;

namespace UnitTests
{
    [TestFixture]
    public class SorterTest
    {
        [TestCase(new int[] { 2, 1, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 081, 782, 322 }, new int[] { 81, 322, 782 })]
        public void Bubble_Sort_Test(int[] input, int[] expectedResult)
        {
            // arrange
            Sorter sorter = new Sorter();

            // act
            IList<int> actualResult = sorter.BubbleSort(input.ToList());

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

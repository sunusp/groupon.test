using NUnit.Framework;
using TechnicalTests.Stack;

namespace UnitTests
{
    [TestFixture]
    public class StackTest
    {
        [TestCase(1, 1, true, true, true)]
        [TestCase(0, 1, false, false, false)]
        public void Stack_Push_Test_Integer(
            int maxSize,
            int item,
            bool expectedResult,
            bool actualResult,
            bool isItemExists)
        {
            // arrange
            IStack<int> stack = new Stack<int>(maxSize);

            // act
            actualResult = stack.Push(item);

            // assert
            Assert.AreEqual(isItemExists, stack.Contains(item));
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, "item 1", true, true, true)]
        [TestCase(0, "item 2", false, false, false)]
        public void Stack_Push_Test_String(
            int maxSize,
            string item,
            bool expectedResult,
            bool actualResult,
            bool isItemExists)
        {
            // arrange
            IStack<string> stack = new Stack<string>(maxSize);

            // act
            actualResult = stack.Push(item);

            // assert
            Assert.AreEqual(isItemExists, stack.Contains(item));
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, new int[] { 10, 20, 30, 40, 50 }, 50)]
        [TestCase(2, new int[] { 10, 20 }, 20)]
        [TestCase(0, new int[] { }, 0)]
        public void Stack_Pop_Test(
           int maxSize,
           int[] pushedItems,
           int expectedPopedItem)
        {
            // arrange
            IStack<int> stack = new Stack<int>(maxSize);
            foreach (int pushedItem in pushedItems)
            {
                stack.Push(pushedItem);
            }

            // act
            int actualPopedItem = stack.Pop();

            // assert
            Assert.AreEqual(expectedPopedItem, actualPopedItem);
            Assert.AreEqual(false, stack.Contains(expectedPopedItem));
        }

        [TestCase(5, new int[] { 10, 20, 30, 40, 50 }, 5, true)]
        [TestCase(2, new int[] { 10, 20 }, 2, true)]
        [TestCase(0, new int[] { }, 0, false)]
        public void Stack_Peek_Test(
          int maxSize,
          int[] pushedItems,
          int expectedStackCount,
           bool isItemExists)
        {
            // arrange
            IStack<int> stack = new Stack<int>(maxSize);
            foreach (int pushedItem in pushedItems)
            {
                stack.Push(pushedItem);
            }

            int expectedPeekedItem = 0;
            if (pushedItems.Length > 0)
            {
                expectedPeekedItem = pushedItems[pushedItems.Length - 1];
            }

            // act
            int actualPeekedItem = stack.Peek();

            // assert
            Assert.AreEqual(expectedPeekedItem, actualPeekedItem);
            Assert.AreEqual(isItemExists, stack.Contains(expectedPeekedItem));
            Assert.AreEqual(
                expectedStackCount,
                pushedItems.Length > 0 ? pushedItems.Length : 0);
        }

        [TestCase(5, new int[] { 10, 20, 30, 40, 50 })]
        [TestCase(2, new int[] { 10, 20 })]
        public void Stack_Clear_Test(
          int maxSize,
          int[] pushedItems)
        {
            // arrange
            IStack<int> stack = new Stack<int>(maxSize);
            foreach (int pushedItem in pushedItems)
            {
                stack.Push(pushedItem);
            }

            // act
            stack.Clear();

            // assert
            Assert.AreEqual(0, stack.Count());
            Assert.AreNotEqual(pushedItems.Length, stack.Count());
        }
    }
}

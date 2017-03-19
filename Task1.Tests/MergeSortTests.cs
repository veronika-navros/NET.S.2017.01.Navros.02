using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task1.Tests
{
    public class MergeSortTests
    {
        public IEnumerable<TestCaseData> TestData
        {
            get
            {
                yield return new TestCaseData(new[] {1, 2, 3, 4, 5}).Returns(new[] {1, 2, 3, 4, 5});
                yield return new TestCaseData(new[] { 5, 4, 3, 2, 1, 0, -1, -2 }).Returns(new[] { -2, -1, 0, 1, 2, 3, 4, 5 });
                yield return new TestCaseData(new[] { 1, 1, 1, 1 }).Returns(new[] { 1, 1, 1, 1 });
                yield return new TestCaseData(new[] { 4 }).Returns(new[] { 4 });
                yield return new TestCaseData(new[] { 7, 4, -6, 8, 3, 4, 0, -2 }).Returns(new[] { -6, -2, 0, 3, 4, 4, 7, 8 });
            }
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, ExpectedResult = new[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 5, 4, 3, 2, 1, 0, -1, -2 }, ExpectedResult = new[] { -2, -1, 0, 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 1, 1, 1, 1 }, ExpectedResult = new[] { 1, 1, 1, 1 })]
        [TestCase(new[] { 4 }, ExpectedResult = new[] { 4 })]
        [TestCase(new[] { 7, 4, -6, 8, 3, 4, 0, -2 }, ExpectedResult = new[] { -6, -2, 0, 3, 4, 4, 7, 8 })]
        public int[] Sort_SortedArray(int[] array)
        {
            return MergeSort.Sort(array);
        }

        [TestCase(null)]
        public void Sort_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => MergeSort.Sort(array));
        }
    }
}

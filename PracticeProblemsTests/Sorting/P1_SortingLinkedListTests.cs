using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PracticeProblems.Sorting.Tests
{
    [TestClass()]
    public class P1_SortingLinkedListTests
    {
        [TestMethod()]
        [DataRow(3, 3, 10, 20, 1, 5, 7)]
        [DataRow(0)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(3, 3, 3, 13, 1, 3, 7)]
        public void MergeSortTests(int nodeASize, params int[] ints)
        {
            P1_SortingLinkedList.Node? a = null;
            P1_SortingLinkedList.Node? b = null;

            if (nodeASize > 0)
                a = new P1_SortingLinkedList.Node(ints[0..nodeASize]);

            if (ints.Length - nodeASize > 0)
                b = new P1_SortingLinkedList.Node(ints[nodeASize..]);

            var result = P1_SortingLinkedList.MergeSort(a, b);

            foreach (var i in ints.OrderBy(x => x))
            {
                Assert.AreEqual(i, result!.Data);
                result = result.Next;
            }
        }

        [TestMethod()]
        [DataRow(3, 3, 10, 20, 1, 5, 7)]
        [DataRow(0)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(3, 3, 3, 13, 1, 3, 7)]
        public void SolutionTests(int nodeASize, params int[] ints)
        {
            P1_SortingLinkedList.Node? a = null;
            P1_SortingLinkedList.Node? b = null;

            if (nodeASize > 0)
                a = new P1_SortingLinkedList.Node(ints[0..nodeASize]);

            if (ints.Length - nodeASize > 0)
                b = new P1_SortingLinkedList.Node(ints[nodeASize..]);

            var result = P1_SortingLinkedList.Solution(a, b);

            foreach (var i in ints.OrderBy(x => x))
            {
                Assert.AreEqual(i, result!.Data);
                result = result.Next;
            }
        }
    }
}
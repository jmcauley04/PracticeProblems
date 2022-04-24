﻿namespace PracticeProblems.LinkedLists;

/// <summary>
/// Write a function that takes in the head of two linked lists as arguments. The function should zipper the two lists together into single linked list by alternating nodes. If one of the linked lists is longer than the other, the resulting list should terminate with the remaining nodes. The function should return the head of the zippered linked list.
///	<br /> Do this in-place, by mutating the original Nodes.
///	<br /> You may assume that both input lists are non-empty.
/// </summary>
public class P8_Zipper
{
    #region Solution

    public static Node<T> Solution<T>(Node<T> a, Node<T> b)
    {
        var head = a ?? b;
        var currentA = a;
        var currentB = b;

        while (currentA != null && currentB != null)
        {
            var nextA = currentA.Next;
            currentA.Next = currentB;
            currentA = nextA;

            if (currentA != null)
            {
                var nextB = currentB.Next;
                currentB.Next = currentA;
                currentB = nextB;
            }
        }

        return head;
    }

    #endregion
}

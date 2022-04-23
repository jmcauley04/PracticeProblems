﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeProblems.Arrays;
using System.Linq;

namespace SolutionTests.Arrays.Tests;

[TestClass()]
public class P1_MaxValueArrayTests
{
    [TestMethod()]
    [DataRow(0)]
    [DataRow(5, 10, -5, 12)]
    [DataRow(1, 2, 3, 4)]
    [DataRow(9, 8, 7, 6, 5, 4, 3)]
    public void SolutionTest(params int[] ints)
    {
        Assert.AreEqual(ints.Max(), P1_MaxValueArray.Solution(ints));
    }
}

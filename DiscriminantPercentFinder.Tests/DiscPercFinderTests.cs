namespace DiscriminantPercentFinder.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class DiscPercFinderTests
{
    private static List<(double, double, double, (double?, double?))> testCases;

    [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
        testCases = new List<(double, double, double, (double?, double?))>
        {
            (1, 2, 3, (null, null)), // D < 0
            (1, -2, 1, (1, 1)), // D = 0
            (1, -3, 2, (2, 1)) // D > 0
        };
    }

    [TestMethod]
    public void TestFindRoots_D_LessThanZero()
    {
        var (a, b, c, expected) = testCases[0];
        var result = DiscPercFinder.FindRoots(a, b, c);
        var actual = new List<double?> { result.Item1, result.Item2 };
        var expectedList = new List<double?> { expected.Item1, expected.Item2 };
        CollectionAssert.AreEqual(expectedList, actual);
    }

    [TestMethod]
    public void TestFindRoots_D_EqualToZero()
    {
        var (a, b, c, expected) = testCases[1];
        var result = DiscPercFinder.FindRoots(a, b, c);
        var actual = new List<double?> { result.Item1, result.Item2 };
        var expectedList = new List<double?> { expected.Item1, expected.Item2 };
        CollectionAssert.AreEquivalent(expectedList, actual);
    }

    [TestMethod]
    public void TestFindRoots_D_GreaterThanZero()
    {
        var (a, b, c, expected) = testCases[2];
        var result = DiscPercFinder.FindRoots(a, b, c);
        var actual = new List<double?> { result.Item1, result.Item2 };
        var expectedList = new List<double?> { expected.Item1, expected.Item2 };
        CollectionAssert.AreEqual(expectedList, actual);
    }
    
    [TestMethod]
    public void TestFindRoots_D_AllUnique()
    {
        var (a, b, c, expected) = testCases[2];
        var result = DiscPercFinder.FindRoots(a, b, c);
        var actual = new List<double?> { result.Item1, result.Item2 };
        CollectionAssert.AllItemsAreUnique(actual);
    }
    
    [TestMethod]
    public void TestCalculatePercentage_Number_ReturnsPercentage()
    {
        double number = 200.0;
        double percentage = 10.0;
        double expected = 20.0;
        double result = DiscPercFinder.CalculatePercentage(number, percentage);
        var actual = new List<double> { result };
        var expectedList = new List<double> { expected };
        CollectionAssert.IsSubsetOf(expectedList, actual);
    }
    
    [TestMethod]
    public void TestCalculatePercentage_Number_ReturnsPercentageWithDelta()
    {
        double number = 200.0;
        double percentage = 10.0;
        double expected = 20.0;
        double delta = 0.01;
        double result = DiscPercFinder.CalculatePercentage(number, percentage);
        Assert.AreEqual(expected, result, delta);
    }
}

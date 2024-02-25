using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class Tests
{
    [TestMethod]
    public void TestDisplaySquare()
    {
        // Arrange
        int sideLength = 3;
        char symbol = '*';

        // Act
        SquareDisplay.DisplaySquare(sideLength, symbol);

    }

    [TestMethod]
    public void TestIsPalindrome()
    {
        // Arrange
        int palindromeNumber = 1221;
        int nonPalindromeNumber = 7854;

        // Act
        bool isPalindromeResult = PalindromeChecker.IsPalindrome(palindromeNumber);
        bool isNonPalindromeResult = PalindromeChecker.IsPalindrome(nonPalindromeNumber);

        // Assert
        Assert.IsTrue(isPalindromeResult);
        Assert.IsFalse(isNonPalindromeResult);
    }

    [TestMethod]
    public void TestFilterArray()
    {
        // Arrange
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };
        int[] expectedArray = { 1, 2, -1 };

        // Act
        int[] resultArray = ArrayFilter.FilterArray(originalArray, filterArray);

        // Assert
        CollectionAssert.AreEqual(expectedArray, resultArray);
    }
}

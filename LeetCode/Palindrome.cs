using static NUnit.Framework.Assert;

namespace LeetCode;

public class Palindrome
{
    public bool IsPalindrome(int x)
    {
        var xAsString = x.ToString();
        return IsPalindromeRec(0, xAsString.Length - 1, xAsString.ToCharArray());
    }

    private bool IsPalindromeRec(int start, int end, char[] x)
    {
        if (start >= end) return true;
        if (x[start] == x[end]) return IsPalindromeRec(start + 1, end - 1, x);
        return false;
    }
}
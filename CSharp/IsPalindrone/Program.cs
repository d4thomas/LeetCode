using System;

class Solution
{
    public bool IsPalindrome(int x)
    {
        string stringNumber = x.ToString();
        char[] charArray = stringNumber.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        return stringNumber == reversedString;
    }

    static void Main(string[] args)
    {
        int x = 212;
        Console.WriteLine(new Solution().IsPalindrome(x));
    }
}
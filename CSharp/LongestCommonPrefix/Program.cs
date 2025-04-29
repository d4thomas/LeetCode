class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        string prefix = strs[0];

        foreach (string str in strs)
        {
            while (!str.StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (string.IsNullOrEmpty(prefix))
                {
                    return "";
                }
            }
        }

        return prefix;
    }

    static void Main(string[] args)
    {
        string[] strs = { "flower", "flow", "flight" };
        Console.WriteLine(new Solution().LongestCommonPrefix(strs));
    }
}
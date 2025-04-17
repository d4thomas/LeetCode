class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> mapping = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char c in s)
        {
            if (mapping.ContainsKey(c))
            {
                char topElement = stack.Count > 0 ? stack.Pop() : '\0';

                if (mapping[c] != topElement)
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();
        string s = "()[]{}";
        bool result = solution.IsValid(s);
        Console.WriteLine(result);
    }
}
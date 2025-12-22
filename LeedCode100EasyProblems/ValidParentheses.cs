namespace LeedCode100EasyProblems;

public class ValidParentheses
{
    Stack<char> stack = new Stack<char>();
    Dictionary<char, char> brackets = new Dictionary<char, char>()
    {
        {'}', '{' },
        {')', '(' },
        {']', '[' },

    };
    public bool IsValid(string s)
    {
        int closeCount = 0;
        int openCount = 0;

        if (s.Length <= 1) return false;
        for (int i = 0; i < s.Length; i++)
        {
            if (!brackets.Values.Contains(s[i]))
            {
                closeCount++;
                if (stack!.Count == 0) return false;
                var lastOpener = stack?.Pop();
                var opener = brackets[s[i]];

                if (lastOpener != opener) return false;
            }
            else
            {
                openCount++;
                stack!.Push(s[i]);
            }
        }
        if (closeCount != openCount) return false;
        return true;
    }
}

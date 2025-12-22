namespace LeedCode100EasyProblems;

public class LengthOfLastWord
{
    public int LengthOfLastWord2(string s)
    {
        s = s.TrimEnd();
        int count = 0;

        for (int i = s.Length-1; i >= 0; i--)
        {
            if (s[i] == ' ') return count;
            count++;
        }

        return 1;
    }
}

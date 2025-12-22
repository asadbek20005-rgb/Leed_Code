namespace LeedCode100EasyProblems;

public class FindTheIndexOfTheFirstOccuranceInAString
{
    public int StrStr(string haystack, string needle)
    {
        if (!haystack.Contains(needle)) return -1;

        for (int i = 0; i < haystack.Length; i++)
        {
            string sub = haystack.Substring(i, needle.Length);
            if(sub.Equals(needle)) return i;
        }

        return -1;
    }
}
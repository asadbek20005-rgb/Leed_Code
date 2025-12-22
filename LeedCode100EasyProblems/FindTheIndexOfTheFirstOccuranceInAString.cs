namespace LeedCode100EasyProblems;

public class FindTheIndexOfTheFirstOccuranceInAString
{
    public int StrStr(string haystack, string needle)
    {
        if(haystack.Length == needle.Length) return 0;
        if(haystack.Length < needle.Length) return -1;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                string sub = haystack.Substring(i, needle.Length);
                if(sub.Equals(needle)) return i;
            }
        }
        return -1;
    }
}
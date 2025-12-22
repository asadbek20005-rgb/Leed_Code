namespace LeedCode100EasyProblems;

public class RomanToInteger
{
    Dictionary<char, int> romanDict = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public int RomanToInt(string s)
    {
        int res = 0;
        int j = 0;

        if (s.Length <= 1)
        {
            return romanDict[s[0]];
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (romanDict[s[i]] >= romanDict[s[j]])
            {
                res += romanDict[s[i]];
            }
            else
            {
                res -= romanDict[s[i]];
            }
            if (j == s.Length - 1)
            {
                return res;
            }

            j++;
        }


        return res;
    }
}

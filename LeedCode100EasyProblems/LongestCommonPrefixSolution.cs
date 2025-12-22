namespace LeedCode100EasyProblems;

public class LongestCommonPrefixSolution
{
    string[] _strs;

    public string LongestCommonPrefix(string[] strs)
    {
        _strs = strs;
        string res = string.Empty;
        int min = strs.Min(x => x.Length);
        string shortestString = strs.FirstOrDefault(x => x.Length == min)!;

        for (int j = 0; j < shortestString.Length; j++)
        {
            if (!Check(shortestString[j].ToString(), j))
            {
                return res;
            }

            res += shortestString[j];
        }


        return res;
    }


    public bool Check(string res, int index)
    {

        for (int j = 0; j < _strs.Length; j++)
        {
            string s = _strs[j];
            if (s[index].ToString() != res)
            {
                return false;
            }
        }

        return true;
    }




    public string LongestCommonPrefix2(string[] strs)
    {
        string str = strs[0];

        for(int i =0; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(str))
            {
                str = str.Substring(0, str.Length - 1);

                if (str == "") return "";
            }
        }

        return str;
    }
}
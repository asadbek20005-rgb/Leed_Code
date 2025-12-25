using System.Text;

namespace LeedCode100EasyProblems;

public class AddBinary
{
    public string AddBinary2(string a, string b)
    {
        var list = new List<int>();

        string result = string.Empty;
        int i = a.Length - 1;
        int j = b.Length - 1;

        while (i >= 0 || j >= 0)
        {
            if (a[i] == '1' && b[j] == '1')
            {
                int carry = list.FirstOrDefault();
                if (carry != 0)
                {
                    result += 1;
                }
                else
                {
                    list.Add(1);
                    result += 0;
                }
            }
            else
            {
                result += ((a[i] - '0') + (a[j] - '0')).ToString();
            }
            i--;
            j--;
        }

        return result;
    }


    public string AddBinary3(string a, string b)
    {
        var sum = new List<int>();
        for (int i = a.Length - 1, j = b.Length - 1, carry = 0; i >= 0 || j >= 0 || carry >= 0;)
        {
            var firstDigit = i >= 0 ? a[i--] - '0' : 0;
            var secondDidit = j >= 0 ? b[j--] - '0' : 0;
            var sumDigit = firstDigit + secondDidit + carry;
            carry = sumDigit / 2;
            sum.Add(sumDigit % 2);
        }

        sum.Reverse();
        return string.Concat(sum);
    }



    public string AddBinary4(string a, string b)
    {
        var builder = new StringBuilder();

        int indexA = a.Length - 1;
        int indexB = b.Length - 1;
        int carryOver = 0;
        while (indexA >= 0 || indexB >= 0 || carryOver == 1)
        {
            int sum = carryOver;
            if (indexA >= 0) sum += a[indexA--] - '0';
            if (indexB >= 0) sum += b[indexB--] - '0';

            builder.Append((char)('0' + (sum & 1)));
            carryOver = (sum >> 1);
        }

        char[] ch = builder.ToString().ToCharArray();

        Array.Reverse(ch);
        return new string(ch);
    }
}

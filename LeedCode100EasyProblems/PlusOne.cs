namespace LeedCode100EasyProblems;

public class PlusOne
{
    public int[] PlusOne2(int[] digits)
    {
        if (digits[0] == 9 && digits.Length == 1) return [1, 0];
        int[] outout = [1];
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
                outout = outout.Append(digits[i]).ToArray();
            }
            else
            {
                digits[i]++;
                return digits;
            }

        }


        return outout;
    }


    public int[] PlusOne3(int[] digits)
    {
        int length = digits.Length;
        if (digits[length - 1] != 9)
        {
            digits[length - 1]++;
            return digits;
        }
        else
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (digits[i] == 9) count++;
            }

            if (count == digits.Length)
            {
                int[] arr = new int[digits.Length + 1];
                arr[0] = 1;
                return arr;
            }
            else
            {
                int c = length - 1;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] == 9)
                    {
                        c--;
                        digits[i] = 0;
                    }
                    else
                    {
                        break;
                    }
                }

                digits[c]++;
                return digits;
            }
        }
    }

}
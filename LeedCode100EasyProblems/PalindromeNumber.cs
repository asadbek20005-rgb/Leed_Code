namespace LeedCode100EasyProblems;

public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        int x1 = x;
        int reversed = 0;
        for (int i = x1; i >= 0; i--)
        {
            int digit = x1 % 10;
            reversed = reversed * 10 + digit;
            i = x1 /= 10;
        }

        return reversed == x;
    }


    public bool IsPalindrome2(int x)
    {
        if(x < 0) return false;

        var a = x;
        var b = 0;

        while(a != 0)
        {
            var test = a % 10;
            var lol = a / 10;

            b = b * 10 + test;
            a = lol;
        }

        if(b == x) return true;

        return false;
    }
}

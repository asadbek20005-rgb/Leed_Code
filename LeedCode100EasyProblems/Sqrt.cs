namespace LeedCode100EasyProblems;

public class Sqrt
{
    public int MySqrt(int x)
    {
        if(x == 0) return 0;    
        int[] nums = { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 };
        int[] nums2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int j = nums.Length - 1; j >= 0; j--)
        {
            if (x >= nums[j])
            {
                return nums2[j];
            }
        }
        return -1;
    }

    public int MySqrt2(int x)
    {
        if (x == 0) return 0;

        int left = 0;
        int right = x;

        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            int sqrt = x / mid;

            if (sqrt == mid) return mid;
            else if (sqrt < mid) right = mid - 1;
            else left = mid + 1;
        }

        return right;
    }
}
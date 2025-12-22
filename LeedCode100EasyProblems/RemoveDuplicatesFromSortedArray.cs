namespace LeedCode100EasyProblems;

public class RemoveDuplicatesFromSortedArray
{

    public int RemoveDuplicates(int[] nums)
    {
        int k = 1;
        int second = 1;
        int i = 0;
        int j = 1;  
        while (second < nums.Length)
        {
            if (nums[i] < nums[second])
            {
                nums[j] = nums[second];
                i++;
                j++;
                k++;
            }
            else
            {
                second++;
            }
        }
        return k;
    }

}

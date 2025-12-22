namespace LeedCode100EasyProblems;

public class RemoveElementSolution
{
    public int RemoveElement(int[] nums, int val)
    {
        int left = 0;
        int right = nums.Length - 1;
        int k = 1;
        while(left <= right)
        {
            if (nums[left] == val)
            {
                if (nums[left] != nums[right])
                {
                    int temp = 0;
                    temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                    left++;
                    right--;
                    k++;
                }
                else
                {
                    right--;
                }
            }
            else
            {
                left++;
                k++;
            }
        }

        return k;
    }
}

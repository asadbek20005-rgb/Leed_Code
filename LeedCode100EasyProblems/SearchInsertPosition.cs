namespace LeedCode100EasyProblems;

public class SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums.Contains(target))
        {
            int value = nums.Where(x => x.Equals(target)).FirstOrDefault();
            if (value != 0)
            {
                return Array.IndexOf(nums, value);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > target) return i;
        }

        return nums.Length;
    }
}

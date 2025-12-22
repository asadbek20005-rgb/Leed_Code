namespace LeedCode100EasyProblems;

public class Two_Sum
{
    public int[] TwoSum(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }


        return [];
    }

    public int[] TwoSum2(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        dictionary[nums[0]] = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (dictionary.ContainsKey(target - nums[i]))
            {
                return new int[] { dictionary[target - nums[i]], i };
            }

            dictionary[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}

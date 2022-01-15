namespace LeetCode.Problems;

public class RemoveDuplicatesfromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums is null || nums.Length == 0)
        {
            return 0;
        }
        int uniqueIndex = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] != nums[i])
            {
                uniqueIndex++;
                nums[uniqueIndex] = nums[i];
            }
        }
        return uniqueIndex + 1;
    }
}

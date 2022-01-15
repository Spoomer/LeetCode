namespace LeetCode.Problems;

public class FindFirstLastPositionSortedArrayProb
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = new int[] { -1, -1 };
        if (nums is null || nums.Length == 0 || nums[0] > target || nums.Last() < target) return result;
        int left = 0;
        int right = nums.Length - 1;
        int searchIndex = nums.Length / 2;
        while (left <= right)
        {
            if (nums[searchIndex] == target)
            {
                result[0] = searchIndex;
                right = searchIndex - 1;
                searchIndex = (left + right) / 2;

            }
            else if (nums[searchIndex] > target)
            {
                right = searchIndex - 1;
                searchIndex = (left + right) / 2;
            }
            else
            {
                left = searchIndex + 1;
                searchIndex = (left + right) / 2;
            }
        }

        left = result[0] > 0 ? result[0] : 0;
        right = nums.Length - 1;
        searchIndex = (left + right) / 2;
        while (left <= right)
        {
            if (nums[searchIndex] == target)
            {
                result[1] = searchIndex;
                left = searchIndex + 1;
                searchIndex = (right + left) / 2;

            }
            else if (nums[searchIndex] > target)
            {
                right--;
                searchIndex = (left + right) / 2;
            }
            else
            {
                left = searchIndex + 1;
                searchIndex = (left + right) / 2;
            }
        }
        return result;

    }
}

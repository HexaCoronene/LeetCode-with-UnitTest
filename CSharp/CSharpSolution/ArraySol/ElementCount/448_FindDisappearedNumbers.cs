namespace LeetCode.Solution.ArraySol.ElementCount;

public class FindDisappearedNumbersSolution
{
    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> ans = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                var nextIndex = nums[i] - 1;
                nums[i] = -1;
                while (nums[nextIndex] != nextIndex + 1)
                {
                    if (nums[nextIndex] == -1)
                    {
                        nums[nextIndex] = nextIndex + 1;
                        break;
                    }
                    (nextIndex, nums[nextIndex]) = (nums[nextIndex] - 1, nextIndex + 1);
                }
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == -1)
            {
                ans.Add(i + 1);
            }
        }

        return ans;
    }
}
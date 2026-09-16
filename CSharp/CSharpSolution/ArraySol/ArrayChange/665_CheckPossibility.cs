namespace LeetCode.Solution.ArraySol.ArrayChange;

public class CheckPossibilitySolution
{
    public static bool CheckPossibility(int[] nums)
    {
        if (nums.Length <= 2) return true;
        bool flag = nums[0] <= nums[1];
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                if (flag)
                {
                    if (nums[i + 1] >= nums[i - 1]) nums[i] = nums[i + 1];
                    else nums[i + 1] = nums[i];
                    flag = false;
                }
                else return false;
            }
        }
        return true;
    }
}
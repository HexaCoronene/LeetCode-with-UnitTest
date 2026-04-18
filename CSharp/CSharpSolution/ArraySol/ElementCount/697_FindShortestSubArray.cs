namespace LeetCode.Solution.ArraySol.ElementCount;

public class FindShortestSubArraySolution
{
    public static int FindShortestSubArray(int[] nums)
    {
        int ans = 0;
        Dictionary<int, (int Left, int Right, int Count)> dic = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.TryGetValue(nums[i], out (int Left, int Right, int Count) num))
            {
                dic.Add(nums[i], (i, i, 1));
            }
            else
            {
                num.Right = i;
                num.Count++;
                dic[nums[i]] = num;
            }
        }

        int max = 0;
        foreach (var item in dic)
        {
            if (item.Value.Count > max)
            {
                max = item.Value.Count;
                ans = item.Value.Right - item.Value.Left + 1;
            }
            else if (item.Value.Count == max)
            {
                int temp = item.Value.Right - item.Value.Left + 1;
                ans = (temp < ans) ? temp : ans;
            }
        }

        return ans;
    }
}
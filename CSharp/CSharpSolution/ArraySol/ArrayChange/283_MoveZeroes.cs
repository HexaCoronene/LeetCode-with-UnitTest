namespace LeetCode.Solution.ArraySol.ArrayChange;

public class MoveZeroesSolution
{
    public static void MoveZeroes(int[] nums)
    {
        List<int> lst = new();
        var zeroCnt = 0;
        foreach (var num in nums)
        {
            if (num != 0)
                lst.Add(num);
            else
                zeroCnt++;
        }

        while (zeroCnt-- != 0)
            lst.Add(0);

        Array.Copy(lst.ToArray(), nums, nums.Length);
    }
}
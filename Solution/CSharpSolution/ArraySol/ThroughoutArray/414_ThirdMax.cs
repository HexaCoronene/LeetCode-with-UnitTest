namespace LeetCode.Solution.ArraySol;

public class ThirdMaxSolution
{
    public static int ThirdMax(int[] nums)
    {
        long a = long.MinValue, b = long.MinValue, c = long.MinValue;
        foreach (long num in nums)
        {
            if (num > a)
                (a, b, c) = (num, a, b);
            else if (a > num && num > b)
                (b, c) = (num, b);
            else if (b > num && num > c)
                c = num;
        }
        return c == long.MinValue ? (int)a : (int)c;
    }
}
namespace LeetCode.Solution.ArraySol.ThroughoutArray;

public class MaximumProductSolution
{
    public static int MaximumProduct(int[] nums)
    {
        // Define : min1 <= min2
        int min1 = int.MaxValue, min2 = int.MaxValue;
        // Define : max1 <= max2 <= max3
        int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;

        foreach (var num in nums)
        {
            if (num < min1)
            {
                (min1, min2) = (num, min1);
            }
            else if (num < min2)
            {
                min2 = num;
            }

            if (num > max3)
            {
                (max1, max2, max3) = (max2, max3, num);
            }
            else if (num > max2)
            {
                (max1, max2) = (max2, num);
            }
            else if (num > max1)
            {
                max1 = num;
            }
        }

        return Math.Max(min1 * min2 * max3, max1 * max2 * max3);
    }
}

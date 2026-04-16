namespace LeetCode.Solution.ArraySol;

public class FindPoisonedDurationSolution
{
    public static int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        int sum = duration;
        for (int i = 0; i < timeSeries.Length - 1; i++)
            sum += Math.Min(timeSeries[i + 1] - timeSeries[i], duration);
        return sum;
    }
}
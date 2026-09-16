namespace LeetCode.Solution.ArraySol.ArrayChange;

public class MinMovesSolution
{
    public static int MinMoves(int[] nums) =>
        nums.Sum() - nums.Min() * nums.Length;
}
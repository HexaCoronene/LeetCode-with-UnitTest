using LeetCode.Solution;

namespace LeetCode.Solution.ArraySol.ArrayRotate;

public class RotateArraySolution
{
    public static void Rotate(int[] nums, int k)
    {
        k %= nums.Length;

        var rev = nums.Reverse().ToArray();
        var rot = rev[..k].Reverse().Concat(rev[k..rev.Length].Reverse()).ToArray();
        Array.Copy(rot, nums, nums.Length);
    }
}
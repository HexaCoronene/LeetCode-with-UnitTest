// 杨辉三角2

namespace LeetCode.Solution.ArraySol.TwoDimensionArray;

public class PascalTriangleIISolution
{
    public static IList<int> GetRow(int rowIndex)
    {
        List<int> ans = new(rowIndex + 1);
        long idx = 1;
        for (int i = 0; i <= rowIndex; i++)
        {
            ans.Add((int)idx);
            idx = idx * (rowIndex - i) / (i + 1);
        }
        return ans;
    }
}
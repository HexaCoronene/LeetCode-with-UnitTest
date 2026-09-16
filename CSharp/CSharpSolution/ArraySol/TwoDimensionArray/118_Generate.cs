// 杨辉三角

namespace LeetCode.Solution.ArraySol.TwoDimensionArray;

public class PascalTriangleSolution
{
    public static IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> list = [[1]];
        for (int i = 1; i < numRows; i++)
        {
            List<int> ints = [1];
            for (int j = 1; j < i; j++)
            {
                ints.Add(list[i - 1][j - 1] + list[i - 1][j]);
            }
            ints.Add(1);
            list.Add(ints);
        }
        return list;
    }
}

namespace LeetCode.UnitTest.BinarySearch;

public class Solution658_FindClosestElements_Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, 3, new int[] { 1, 2, 3, 4 })]
    [InlineData(new int[] { 1, 1, 2, 3, 4, 5 }, 4, -1, new int[] { 1, 1, 2, 3 })]
    public void FindClosestElements_Input_Return(int[] arr, int k, int x, int[] expected)
    {
        Assert.Equal(expected, FindClosestElementsSolution.FindClosestElements(arr, k, x));
    }
}

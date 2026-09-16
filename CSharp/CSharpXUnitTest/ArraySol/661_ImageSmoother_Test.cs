namespace LeetCode.UnitTest.ArraySol;

public class Solution661_ImageSmoother_Test
{
    public static IEnumerable<object[]> Matrix
    {
        get =>
            [
                [
                    new int[][] { [1, 1, 1], [1, 0, 1], [1, 1, 1] },
                    new int[][] { [0, 0, 0], [0, 0, 0], [0, 0, 0] },
                ],
            ];
    }

    [Theory]
    [MemberData(nameof(Matrix))]
    public void ImageSmoother_Input2dArray_Return2dArray(int[][] img, int[][] expected)
    {
        Assert.Equal(expected.Length, img.Length);
        var items = ImageSmootherSolution.ImageSmoother(img);
        for (int i = 0; i < expected.Length; i++)
            Assert.True(expected[i].SequenceEqual(items[i]));
    }
}

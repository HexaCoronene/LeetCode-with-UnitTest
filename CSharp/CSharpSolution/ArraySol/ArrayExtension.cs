namespace LeetCode.Solution.ArraySol;

public static class ArrayExtension
{
    public static int[][] ToJaggedArray(this int[,] array)
        => Enumerable.Range(0, array.GetLength(0)).Select(row =>
            Enumerable.Range(0, array.GetLength(1)).Select(col => array[row, col]).ToArray()
        ).ToArray();

    public static bool ElementEqual(this int[] array, int[] compared)
    {
        var q = (
            from a in array
            join b in compared
            on a equals b
            select a
        );
        return array.Length == compared.Length && q.Count() == array.Length;
    }
}
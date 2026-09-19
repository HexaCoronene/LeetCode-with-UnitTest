namespace LeetCode.Solution.BinarySearch;

public class PreimageSizeFZFSolution
{
    public static int PreimageSizeFZF(int k)
    {
        //计算末尾0
        static int calZero(long n)
        {
            int ans = 0;
            while (n != 0)
            {
                n /= 5;
                ans += (int)n;
            }
            return ans;
        }

        //二分法计算第一个x,使得 f(x) = k
        static int CalMinKZero(int k)
        {
            long left = 0L;
            long right = 5L * k;
            while (left < right)
            {
                long mid = left + (right - left) / 2;
                if (k <= calZero(mid))
                    right = mid;
                else
                    left = mid + 1;
            }
            return (int)left;
        }
        
        return CalMinKZero(k + 1) - CalMinKZero(k);
    }
}
#include <algorithm>
#include <vector>
#include <cmath>
#include <set>

using namespace std;

class thirdMaxSolution
{
public:
    int thirdMax(vector<int> &nums)
    {
        int64_t INF = -1e18;
        int64_t a = INF, b = INF, c = INF;
        for (auto x : nums)
        {
            if (x > a)
            {
                c = b;
                b = a;
                a = x;
            }
            else if (x > b && x < a)
            {
                c = b;
                b = x;
            }
            else if (x > c && x < b)
            {
                c = x;
            }
        }

        return (c != INF) ? c : a;
    }
};

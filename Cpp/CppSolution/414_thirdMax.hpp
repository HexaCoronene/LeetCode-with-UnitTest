#include <vector>
#include <climits>

using namespace std;

class thirdMaxSolution
{
public:
	int thirdMax(vector<int>& nums)
	{
		int INF = INT_MIN;
		int a = INF, b = INF, c = INF;
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

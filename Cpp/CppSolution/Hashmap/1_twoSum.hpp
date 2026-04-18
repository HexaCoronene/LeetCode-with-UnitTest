#include <vector>
#include <unordered_map>

using namespace std;

class twoSumSolution
{
public:
	vector<int> twoSum(vector<int>& nums, int target)
	{
		unordered_map<int, int> hashtable;

		for (int i = 0; i < nums.size(); i++)
		{
			auto it = hashtable.find(target - nums[i]);
			if (it != hashtable.end()) //不为空说明找到
			{
				return { it->second, i };
			}
			hashtable[nums[i]] = i;
		}

		return { };
	}
};


#include "pch.h"
#include "Hashmap/1_twoSum.hpp"

#include <algorithm>
#include <vector>

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace CppUnitTestHashmap
{
	TEST_CLASS(TwoSumTests)
	{
	public:

		TEST_METHOD(TestTwoSum)
		{
			twoSumSolution sol;
			std::vector<int> v1{ 2,7,11,15 }, expected{ 0,1 };
			auto res = sol.twoSum(v1, 9);
			std::sort(res.begin(), res.end());

			Assert::IsTrue(res == expected);
		}
	};
}


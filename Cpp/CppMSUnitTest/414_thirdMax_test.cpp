#include "pch.h"
#include "414_thirdMax.hpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace CppUnitTestArray {
	TEST_CLASS(ThirdMaxTests) {
public:
	TEST_METHOD(TestThirdMax1)
	{
		thirdMaxSolution solution;
		vector<int> nums1{ 3,2,1 };
		Assert::AreEqual(1, solution.thirdMax(nums1));
	}
	TEST_METHOD(TestThirdMax2)
	{
		thirdMaxSolution solution;
		vector<int> nums2{ 1,2 };
		Assert::AreEqual(2, solution.thirdMax(nums2));
	}
	};
}
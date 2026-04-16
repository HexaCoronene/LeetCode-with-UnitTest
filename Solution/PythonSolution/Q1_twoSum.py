# LeetCode 1 Easy


class Solution:
    def twoSum(self, nums: list[int], target: int) -> list[int]:
        d = {}
        for index, num in enumerate(nums):
            if target - num in d:
                return [d[target - num], index]
            d[num] = index
        return [0, 1]

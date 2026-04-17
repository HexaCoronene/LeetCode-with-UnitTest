import unittest
from PythonSolution.Q1_twoSum import Solution


class TwoSumTestCase(unittest.TestCase):
    def test_twoSum(self):
        sol = Solution()
        self.assertListEqual([1, 2], sol.twoSum([3, 2, 4], 6))
        self.assertListEqual([0, 1], sol.twoSum([2, 7, 11, 15], 9))

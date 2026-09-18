import unittest
from PythonSolution.Q162_findPeakElement import findPeakElementSolution


class FindPeakElementTestCase(unittest.TestCase):
    def setUp(self):
        self.sol = findPeakElementSolution()

    def test_findPeakElement1(self):
        self.assertTrue(self.sol.findPeakElement1([1, 2, 1, 3, 5, 6, 4]) in [1, 5])
        self.assertEqual(self.sol.findPeakElement1([1, 2, 3, 1]), 2)  
        self.assertEqual(self.sol.findPeakElement1([1]), 0)  
        self.assertEqual(self.sol.findPeakElement1([1, 2]), 1)  
        self.assertEqual(self.sol.findPeakElement1([2, 1]), 0)  

    def test_findPeakElement2(self):
        self.assertTrue(self.sol.findPeakElement2([1, 2, 1, 3, 5, 6, 4]) in [1, 5])
        self.assertEqual(self.sol.findPeakElement2([1, 2, 3, 1]), 2)  
        self.assertEqual(self.sol.findPeakElement2([1]), 0)  
        self.assertEqual(self.sol.findPeakElement2([1, 2]), 1)  
        self.assertEqual(self.sol.findPeakElement2([2, 1]), 0)  




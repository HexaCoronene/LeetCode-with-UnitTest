class findPeakElementSolution:
    def findPeakElement1(self, nums: list[int]) -> int:
        # [0, n-2]
        left = 0
        right = len(nums) - 2

        while left <= right:
            mid = (left + right) // 2
            if nums[mid] > nums[mid + 1]:
                right = mid - 1
            else:
                left = mid + 1

        return left

    def findPeakElement2(self, nums: list[int]) -> int:
        # (-1, n-1)
        left = -1
        right = len(nums) - 1

        while left + 1 < right:
            mid = (left + right) // 2
            if nums[mid] > nums[mid + 1]:
                right = mid
            else:
                left = mid

        return right

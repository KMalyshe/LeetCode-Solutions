class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        ret = []
        for i, n in enumerate(nums):
            if (target-n) in nums[i+1:]:
                ret.append(i)
                del nums[i]
                ret.append(nums.index(target-n)+1)
            else:
                continue
            return ret
            
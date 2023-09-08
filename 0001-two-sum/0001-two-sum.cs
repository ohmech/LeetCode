public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int Length = nums.Length;
        for(int i = 0; i < Length; i++)
        {
            for(int j = i+1; j < Length; j++)
            {
                if(nums[i]+nums[j]==target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { 0, 0 };
    }
}
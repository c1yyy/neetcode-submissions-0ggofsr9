public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        
        Dictionary<int, int> memo = new Dictionary<int, int>();
        
        int evenPath = ExplorePath(nums, 0, memo);
        int oddPath = ExplorePath(nums, 1, memo);
        return Math.Max(evenPath, oddPath);
    }

    public int ExplorePath(int[] nums, int rootIndex, Dictionary<int, int> memo)
    {
        if (rootIndex >= nums.Length) return 0;
        if (memo.ContainsKey(rootIndex)) return memo[rootIndex];

        int option1 = nums[rootIndex] + ExplorePath(nums, rootIndex + 2, memo);
        int option2 = nums[rootIndex] + ExplorePath(nums, rootIndex + 3, memo);
        
        int result = Math.Max(option1, option2);
        memo[rootIndex] = result;
        return result;
    }
}
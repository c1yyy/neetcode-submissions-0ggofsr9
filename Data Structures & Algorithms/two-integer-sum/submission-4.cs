public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> set = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(!set.ContainsKey(nums[i]))
            {
            set.Add(nums[i], i);
            }
            else if(nums[i] * 2 == target)
            {
                int[] result = new int[2]{ set[nums[i]], i };
                return result;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int compliment = target - nums[i];
            if (set.ContainsKey(compliment) && set[compliment] != i)
            {
                int[] result = new int[2]{ i, set[compliment] };
                Array.Sort(result);
                return result;
            }
        }

        return null;
    }
}

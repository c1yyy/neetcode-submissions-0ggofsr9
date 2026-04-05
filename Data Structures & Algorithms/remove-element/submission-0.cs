public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int nextPosition = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[nextPosition] = nums[i];
                nextPosition++;
            }
        }
        return nextPosition;
    }
}
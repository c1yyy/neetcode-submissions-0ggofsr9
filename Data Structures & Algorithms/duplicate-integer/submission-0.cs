public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> hashSet = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!hashSet.ContainsKey(num))
            {
                hashSet.Add(num, 1);
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}
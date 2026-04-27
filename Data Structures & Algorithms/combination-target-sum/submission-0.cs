public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) 
    {
        List<List<int>> results = new List<List<int>>();
        DFS(nums, target, 0, new List<int>(), results);
        return results;
    }

    public void DFS(int[] nums, int remaining, int start, List<int> current, List<List<int>> results)
    {
        if (remaining == 0) {
            results.Add(new List<int>(current));
            return;
        }
        if (remaining < 0) return;

        for (int i = start; i < nums.Length; i++) {
            current.Add(nums[i]);
            DFS(nums, remaining - nums[i], i, current, results);
            current.RemoveAt(current.Count - 1);
        }
    }
}

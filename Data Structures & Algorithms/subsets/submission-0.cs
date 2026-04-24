public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        result.Add(new List<int>());
        foreach (int num in nums)
        { 
            int currentSize = result.Count;
            for (int i = 0; i < currentSize; i++)
            {
                List<int> subset = new List<int>(result[i]);
                subset.Add(num);
                result.Add(subset);
            }

        }
        return result;
    }
}

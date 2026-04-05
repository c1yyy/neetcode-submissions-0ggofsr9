public class Solution {
    public int RemoveDuplicates(int[] nums) {
      
      List<int> verifiedList = new List<int>(); 
      
      for (int i = 0; i < nums.Length; i++)
      {
        bool isDuplicate = false;
        for (int o = 0; o < verifiedList.Count; o++)
        {
          if (nums[i] == verifiedList[o])
          {
            isDuplicate = true;
            break;
          }
        }
        if (!isDuplicate) {
          nums[verifiedList.Count] = nums[i];
          verifiedList.Add(nums[i]);
        }
      }
      return verifiedList.Count;  
    }
}
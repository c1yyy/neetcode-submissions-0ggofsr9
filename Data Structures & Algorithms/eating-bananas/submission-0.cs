
public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
    int mid;
    int high = piles.Max();
    int low = 1;
    List<int>candidates = new List<int>();

    while (low <= high) {
        mid = low + (high - low) / 2;

        if (CanFinish(piles, h, mid)) 
        {
            candidates.Add(mid); 
            high = mid - 1;
        } 
        else
        {
            low = mid + 1;
        } 

    }
    return candidates.Min();
    }
        public bool CanFinish(int[] piles, int h, int k) {
        int hoursSpent = 0;
        foreach (int pile in piles)
        {
            hoursSpent += (pile + k - 1) / k;
        }
        return hoursSpent <= h;
    }
}


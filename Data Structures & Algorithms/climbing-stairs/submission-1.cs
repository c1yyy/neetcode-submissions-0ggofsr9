public class Solution {
    public int ClimbStairs(int n) {  
        if (n - 1 == 0)
        {
            return 1;
        } 
        else if (n - 2 == 0)
        {
            return 2;
        }
        else if (n - 1 < 0 || n - 2 < 0)
        {
            return 0;
        }

        return ClimbStairs(n - 1) + ClimbStairs (n - 2);
    }
}

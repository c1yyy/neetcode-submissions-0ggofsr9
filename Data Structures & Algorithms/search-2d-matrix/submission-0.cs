public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for (int i = 0; i < matrix.Length; i++)
        {
            int lastOfRow = matrix[i][matrix[i].Length - 1];
            if (lastOfRow >= target)
            {
                int l = 0;
                int h = matrix[i].Length - 1;
                while (l <= h)
                {
                    int mid = (h + l) / 2;
                    if (matrix[i][mid] > target)
                    {
                        h = mid - 1;
                    }
                    else if (matrix[i][mid] < target)
                    {

                        l = mid + 1;
                    }
                    else 
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        return false;
    }
}

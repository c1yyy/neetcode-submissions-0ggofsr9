public class Solution {
    public int CountPaths(int[][] grid) {
        int[][] visits = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++) visits[i] = new int[grid[0].Length];
        return dfs(grid, 0, 0, visits);
    }

    public int dfs(int[][] grid, int r, int c, int[][] visits)
    {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == 1 || visits[r][c] == 1)
        {
            return 0;
        }
        else if (r == grid.Length - 1 && c == grid[0].Length - 1)
        {
            return 1;
        }
        
        visits[r][c] = 1;

        int counts = 0;
        counts += dfs(grid, r + 1, c, visits);
        counts += dfs(grid, r - 1, c, visits);
        counts += dfs(grid, r, c + 1, visits);
        counts += dfs(grid, r, c - 1, visits);

        visits[r][c] = 0;
        return counts;
    }
}
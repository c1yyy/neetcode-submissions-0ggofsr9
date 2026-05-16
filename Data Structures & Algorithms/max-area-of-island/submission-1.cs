public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int[][] checks = new int[grid.Length][];
        List<int> islands = new List<int>();
        for (int i = 0; i < grid.Length; i++) checks[i] = new int [grid[i].Length];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (checks[i][j] == 0)
                {
                    islands.Add(dfs(grid, i, j, checks));
                }
            }
        }
        return islands.Max();
    }

    public int dfs(int[][] grid, int r, int c, int[][] checks)
    {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == 0 || checks[r][c] == 1)
        {
            return 0;
        }
        checks[r][c] = 1;
        int islandSize = 1;

        islandSize += dfs(grid, r - 1, c, checks);
        islandSize += dfs(grid, r + 1, c, checks);
        islandSize += dfs(grid, r, c - 1, checks);
        islandSize += dfs(grid, r, c + 1, checks);

        return islandSize;
    }
}

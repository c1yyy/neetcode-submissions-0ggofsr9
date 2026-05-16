public class Solution {
    public int NumIslands(char[][] grid) {
        int counts = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != '0')
                {
                    counts += dfs(grid, i, j);
                }
            }
        }
        return counts;
    }

    public int dfs(char[][] grid, int r, int c)
    {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == '0' )
        {
            return 0;
        }
        grid[r][c] = '0';
        int count = 1;

        dfs(grid, r - 1, c);
        dfs(grid, r + 1, c);
        dfs(grid, r, c - 1);
        dfs(grid, r, c + 1);

        return count;
    }
    
}

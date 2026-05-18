public class Solution {
    public int OrangesRotting(int[][] grid) {
        int ROWS = grid.Length, COLS = grid[0].Length;
        List<int[]> modifyingVertexIndices = new List<int[]>();  
        int totalUnmodified = 0;

        int totalSteps = 0;
        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS; j++)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }
                if (grid[i][j] == 1)
                {
                    totalUnmodified++;
                }
                if (grid[i][j] == 2)
                {
                    modifyingVertexIndices.Add(new int[2]{ i, j });
                }
            }
        }

        if (totalUnmodified == 0) return 0;

        Queue<int[]> queue = new Queue<int[]>();
        foreach (var startPos in modifyingVertexIndices) queue.Enqueue(startPos);
        
        while (queue.Any())
        {

            int size = queue.Count;
            bool changed = false;
            for (int i = 0; i < size; i++)
            {
                int[] pair = queue.Dequeue();
                int r = pair[0], c = pair[1];

                int[][] dirs = { new int[]{-1, 0}, new int[]{1, 0}, new int[]{0, -1}, new int[]{0, 1} };
                foreach (var d in dirs) {
                    int nr = r + d[0], nc = c + d[1];
                    if (nr >= 0 && nr < ROWS && nc >= 0 && nc < COLS && grid[nr][nc] == 1) {
                        grid[nr][nc] = 2;
                        totalUnmodified--;
                        queue.Enqueue(new int[]{nr, nc});
                        changed = true;
                    }
                }

            }
            if (changed) totalSteps++;
        }
        return totalUnmodified == 0 ? totalSteps : -1;
    }
}

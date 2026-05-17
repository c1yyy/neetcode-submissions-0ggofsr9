public class Solution {
    public int ShortestPath(int[][] grid) {
        int ROWS = grid.Length, COLS = grid[0].Length;
        int[][] visits = new int[ROWS][];
        for ( int i = 0; i < ROWS; i++ ) visits[i] = new int[COLS];
        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[]{0, 0});
        int length = 0;
        while (queue.Any())
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                int[] pair = queue.Dequeue();
                int r = pair[0], c = pair[1];

                if (r < 0 || c < 0 || r >= ROWS || c >= COLS || grid[r][c] == 1 || visits[r][c] == 1)
                {
                    continue;
                }
                if (r == ROWS - 1 && c == COLS - 1)
                {
                    return length;
                }
                visits[r][c] = 1;
                
                queue.Enqueue(new int[]{r - 1, c});
                queue.Enqueue(new int[]{r + 1, c});
                queue.Enqueue(new int[]{r, c - 1});
                queue.Enqueue(new int[]{r, c + 1});
            }
            length++;
        }
        return -1;
    }
}

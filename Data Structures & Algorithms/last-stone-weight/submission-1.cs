public class Solution {
    public int LastStoneWeight(int[] stones) {
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        foreach (int stone in stones)
        {
            queue.Enqueue(stone, stone);
        }
        while (queue.Count > 1)
        {
            int aStone = queue.Dequeue();
            int bStone = queue.Dequeue();
            if (aStone == bStone)
            {
                continue;
            }
            else
            {
                queue.Enqueue(aStone - bStone, aStone - bStone);
            }
        }
        if (queue.Count != 0)
        {
            return queue.Peek();
        }
        return 0;
    }
}

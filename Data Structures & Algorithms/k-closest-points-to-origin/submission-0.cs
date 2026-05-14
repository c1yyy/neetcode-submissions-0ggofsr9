public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int, double> minHeap = new PriorityQueue<int, double>();
        double euclideanDistance;
        int index = 0;
        foreach(int[] cSet in points)
        {
            euclideanDistance = Math.Sqrt(Math.Pow(cSet[0] - 0, 2) + Math.Pow(cSet[1] - 0, 2));
            minHeap.Enqueue(index, euclideanDistance);
            index++;
        }
        int[][] result = new int[k][];
        for (int i = 0; i < k; i++)
        {
            index = minHeap.Dequeue();
            result[i] = points[index];
        }
        return result;
    }
}

public class KthLargest {
    private PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
    private int kth;

    public KthLargest(int k, int[] nums) {
        kth = k;
        foreach (int n in nums)
        {
            Add(n);
        }
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);
        if (minHeap.Count > kth)
        {
            minHeap.Dequeue();
        }
        return minHeap.Peek();
    }
}

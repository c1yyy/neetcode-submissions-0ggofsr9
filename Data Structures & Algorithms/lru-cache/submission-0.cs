public class LRUCache {

    public int Capacity;
    public Dictionary<int, int> KVPList = new Dictionary<int, int>();
    public LinkedList<int> DLList = new LinkedList<int>();

    public LRUCache(int capacity) {
        Capacity = capacity; 
    }
    
    public int Get(int key) {
        if(KVPList.ContainsKey(key))
        {            
            DLList.Remove(key);
            DLList.AddFirst(key);
            return KVPList[key];
        }
        return -1;
    }

    public void Put(int key, int value) {
        if (KVPList.ContainsKey(key))
        {            
            DLList.Remove(key);
            DLList.AddFirst(key);
            KVPList[key] = value;
            return;
        }
        if (KVPList.Count >= Capacity)
        {
            var excessKey = DLList.Last.Value;
            DLList.RemoveLast();
            KVPList.Remove(excessKey);
        }
        DLList.AddFirst(key);
        KVPList.Add(key, value);
    }
}

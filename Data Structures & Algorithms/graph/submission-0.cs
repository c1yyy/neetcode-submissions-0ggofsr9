public class Graph {
    Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

    public Graph() {
    }

    public void AddEdge(int src, int dst) {
    if (!dict.ContainsKey(src))
    {
        dict.Add(src, new List<int>());
    }
    if (!dict.ContainsKey(dst))
    {
        dict.Add(dst, new List<int>());
    }
    if (!dict[src].Contains(dst)) {
        dict[src].Add(dst);
    }
    }

    public bool RemoveEdge(int src, int dst) {
    if (dict.ContainsKey(src) && dict[src].Contains(dst))
    {
        dict[src].Remove(dst);
        return true;
    }
    return false;
    }

    public bool HasPath(int src, int dst) {
    HashSet<int> visited = new HashSet<int>();
    return DFS(src, dst, visited);
    }

    public bool DFS(int current, int target, HashSet<int> visited) {
        if (current == target) return true;
        visited.Add(current);
        foreach (var neighbor in dict[current]) {
            if (!visited.Contains(neighbor)) {
                if (DFS(neighbor, target, visited)) return true;
            }
        }
        return false;
    }
}

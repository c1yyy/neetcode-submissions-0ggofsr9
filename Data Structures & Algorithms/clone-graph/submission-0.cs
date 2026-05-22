/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null)
        {
            return null;
        }
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Node initialNode = node;
        return dfs(initialNode, map);
    }

    public Node dfs(Node node, Dictionary<Node, Node> map)
    {
        if (map.ContainsKey(node))
        {
            return map[node];
        }
        Node copy = new Node(node.val);
        map[node] = copy;

        foreach(Node neighbor in node.neighbors)
        {
            copy.neighbors.Add(dfs(neighbor, map));
        }

        return copy;
    }
}

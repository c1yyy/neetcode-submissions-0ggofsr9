public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
        for (int i = 0; i < numCourses; i++) adj[i] = new List<int>();
        foreach (var pair in prerequisites) adj[pair[0]].Add(pair[1]);

        HashSet<int> visiting = new HashSet<int>();
        HashSet<int> visited = new HashSet<int>();
        for (int i = 0; i < numCourses; i++)
        {
            if (!dfs(i, visiting, visited, adj))
            {
                return false;
            }
        }
        return true;
    }

    public bool dfs(int course, HashSet<int> visiting, HashSet<int> visited, Dictionary<int, List<int>> adj)
    {
        if (visiting.Contains(course))
        {
            return false;
        }
        if (visited.Contains(course))
        {
            return true;
        }

        visiting.Add(course);
        foreach (int prereq in adj[course])
        {
            if (!dfs(prereq, visiting, visited, adj))
            {
                return false;
            }
        }
        
        visiting.Remove(course);
        visited.Add(course);
        return true;
    }
}

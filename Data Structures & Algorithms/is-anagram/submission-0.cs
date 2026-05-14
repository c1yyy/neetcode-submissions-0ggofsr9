public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        char[] char1 = s.ToCharArray();
        char[] char2 = t.ToCharArray();
        Dictionary<char, int> set1 = new Dictionary<char, int>();
        Dictionary<char, int> set2 = new Dictionary<char, int>();
        for (int i = 0; i < char1.Length; i++)
        {
            if(!set1.ContainsKey(char1[i]))
            {
                set1.Add(char1[i], 1);
            }
            else 
            {
                set1.TryGetValue(char1[i], out int val);
                set1[char1[i]] = val + 1;
            }
        }
        for (int i = 0; i < char2.Length; i++)
        {
            if(!set2.ContainsKey(char2[i]))
            {
                set2.Add(char2[i], 1);
            }
            else 
            {
                set2.TryGetValue(char2[i], out int val);
                set2[char2[i]] = val + 1;
            }
        }
        bool areEqual = set1.All(kv => set2.TryGetValue(kv.Key, out var val) && Equals(kv.Value, val));
        return areEqual;
    }
}

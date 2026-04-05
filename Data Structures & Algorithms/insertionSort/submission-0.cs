// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> snapshots = new List<List<Pair>>();
        for (int i = 0; i < pairs.Count(); i++)
        {
            int j = i - 1;
            while (j >= 0 && pairs[j].Key > pairs[j + 1].Key)
            {
                Pair temp = pairs[j + 1];
                pairs[j + 1] = pairs[j];
                pairs[j] = temp;
                j--;
            }
            snapshots.Add(new List<Pair>(pairs));
        }
        return snapshots;
    }
}
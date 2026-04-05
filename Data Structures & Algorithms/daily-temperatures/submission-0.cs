public class Solution {
    
    public class TempDay
    {
        public int Temperature { get; set; }
        public int Index { get; set; }

        public TempDay(int temp, int idx)
        {
                Temperature = temp;
                Index = idx;
        }
    }
    
    public int[] DailyTemperatures(int[] temperatures) {

        Stack<TempDay>stack = new Stack<TempDay>();
        int[] result = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++)
        {
            int currentTemp = temperatures[i];

            while (stack.Count > 0 && currentTemp > stack.Peek().Temperature)
            {
                TempDay colderDay = stack.Pop();
                result[colderDay.Index] = i - colderDay.Index;   
            }
            stack.Push(new TempDay(currentTemp, i));
        }

        return result;
    }
}

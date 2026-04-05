public class Solution {
    public int EvalRPN(string[] tokens) {
        int[] operands = new int[tokens.Length];
        int pointer = -1;  
        
        foreach (string token in tokens) {
            if (int.TryParse(token, out int num)) {
                operands[++pointer] = num;  
            }
            else {
                int b = operands[pointer--];  
                int a = operands[pointer--];  
                
                switch (token) {
                    case "+": operands[++pointer] = a + b; break;
                    case "-": operands[++pointer] = a - b; break;
                    case "*": operands[++pointer] = a * b; break;
                    case "/": operands[++pointer] = a / b; break;
                }
            }
        }
        
        return operands[0];
    }
}

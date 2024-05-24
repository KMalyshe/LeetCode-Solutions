public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length-1; i>-1; i--)
        {
            if (digits[i] != 9) 
            {
                digits[i] = digits[i]+1;
                return digits;
            }
            else
            {
                digits[i] = 0;
                if (i == 0) return allNines(digits);
            }
        }
        return digits;
    }
    
    public int[] allNines(int[] digits)
    {
        int[] ret = new int[digits.Length+1];
        ret[0] = 1;
        return ret;
    }
}
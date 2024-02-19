public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        bool[] result = new bool[candies.Length];
        var highest = 0;
        foreach (int kid in candies) if (kid > highest) highest = kid;
        for (int i = 0; i<result.Length; i++) if (candies[i]+extraCandies >= highest) result[i] = true; else result[i] = false;
        return result;
    }
}
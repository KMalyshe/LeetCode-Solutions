public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        bool[] result = new bool[candies.Length];
        var highest = 0;
        foreach (int kid in candies) highest = Math.Max(highest, kid);
        for (int i = 0; i<result.Length; i++) result[i] = (candies[i]+extraCandies >= highest);
        return result;
    }
}
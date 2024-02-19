public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (String.IsNullOrEmpty(s)) return 0;
        if (s.Length == 1) return 1;
        for (int i = 0; i<s.Length; i++)
        {
            if (!Char.IsWhiteSpace(s[i])) break;
            if (i == s.Length-1) return 1;
        }
        int longest = 0;
        HashSet<char> charSet = new HashSet<char>();
        int l = 0; int r = 0;
        charSet.Add(s[0]);
        for (int i = 1; i<s.Length; i++)
        {
            if (charSet.Contains(s[i]))
            {
                while (s[l] != s[i]) l += 1;
                i = l;
                l++;
                charSet.Clear();
                continue;
            }
            charSet.Add(s[i]);
            if (longest < charSet.Count) longest = charSet.Count;

        }
        return longest;
    }
}
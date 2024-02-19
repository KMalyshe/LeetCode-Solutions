public class Solution {
    public bool CheckIfPangram(string sentence) {
        int l = 0;
        HashSet<char> check = new HashSet<char>();
        while (l<sentence.Length)
        {
            check.Add(sentence[l]);
            if (check.Count == 26) return true;
            l++;
        }
        return false;
    }
}
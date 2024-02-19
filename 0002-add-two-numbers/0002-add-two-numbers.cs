/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        List<int> list1 = getList(l1); List<int> list2 = getList(l2);
        list1.Reverse(); list2.Reverse();
        string str1 = ""; string str2 = "";
        foreach (int num in list1) str1 += num;
        foreach (int num in list2) str2 += num;
        str1 = (BigInteger.Parse(str1) + BigInteger.Parse(str2)).ToString();
        List<int> result = new List<int>();
        foreach (char num in str1) result.Add((int) Char.GetNumericValue(num));
        result.Reverse();
        List<int> removeTrailing0 = result;
        while ((removeTrailing0.Last() == 0) && (removeTrailing0.Count() > 1)) 
        {
            removeTrailing0.RemoveAt(removeTrailing0.Count() - 1);
        }
        if (removeTrailing0.Count() == 1) return new ListNode(removeTrailing0[0], null);
        result = removeTrailing0;
        ListNode node = new ListNode(result[0], new ListNode());
        ListNode firstnode = node;
        for (int i = 1; i<result.Count(); i++)
        {
            node = node.next;
            node.val = result[i];
            if (i != result.Count() - 1) node.next = new ListNode();
        }
        return firstnode;
    }
    
    public List<int> getList(ListNode node)
    {
        List<int> result = new List<int>();
        while (node != null)
        {
            result.Add(node.val);
            node = node.next;
        }
        return result;
    }
}
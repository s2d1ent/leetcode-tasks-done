public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        List<int> a = Checker(l1, new List<int>());
        List<int> b = Checker(l2, new List<int>());
        BigInteger result = 0;
        string astr = "",
               bstr = "";
        for (var i = a.Count - 1; i > -1; i--)
            astr += a[i];
        for (var i = b.Count - 1; i > -1; i--)
            bstr += b[i];
            
        result = BigInteger.Parse(astr)+ BigInteger.Parse(bstr);
        a.Clear();
        for (var i = result.ToString().Length - 1; i > -1; i--)
        {
            a.Add(
                int.Parse($"{result.ToString()[i]}")
                ); ;
        }
            
        return Package(a);
    }
    static List<int> Checker(ListNode ln, List<int> al)
    {
        al.Add(ln.val);
        if (ln.next != null)
            Checker(ln.next, al);
        return al;
    }
    static ListNode Package(List<int> list)
    {
        List<ListNode>  listNode = new List<ListNode>();
        for (var i = 0; i < list.Count; i++)
            listNode.Add(new ListNode(list[i]));            
        for(var i = listNode.Count - 1; i > 0; i--)
            if (i - 1 > -1)
                listNode[i - 1].next = listNode[i];            
        return listNode[0];
    }
}
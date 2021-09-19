public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var list = new List<int>();
        var list1 = new List<int>();
        foreach (var i in nums)
            list.Add(i);
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] == target)
                return i;
        list.Add(target);
        var elem = list.OrderBy(x => x);
        foreach (var i in elem)
            list1.Add(i);
        for (var i = 0; i < list1.Count; i++)
            if (list1[i] == target)
                return i;
        return 0;
    }
}

public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var arr = new List<int>();
        var arr1 = new List<int>();
        var arr2 = new List<int>();
        var dis = nums.OrderBy(x => x).Distinct();
        foreach(var i in dis)
            arr.Add(i);
        for(var i = 0; i < nums.Length; i++)
            arr1.Add(i+1);
        var exc = arr1.Except(arr);
        foreach(var i in exc)
            arr2.Add(i);
        var result = new int[arr2.Count];
        for(var i = 0; i < result.Length; i++)
            result[i]= arr2[i];
        return result;
    }
}
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<string> arr = new List<string>();
        int result = 0;
        string str = "";
        if(s.Length == 0)
            return 0;
        for(var i = 0; i < s.Length; i++)
        {
            str+=s[i];
            arr.Add(str);
            for(var j = 0; j < s.Length; j++)
            {
                if(i == j || j < i)
                    continue;
                if(str.IndexOf(s[j])==-1)
                {
                    str+=s[j];
                    arr.Add(str);
                }
                else
                {
                    str = "";
                    break;
                }
            }
            str="";
        }
        int[] arr1 = new int[arr.Count];
        for(var i = 0; i < arr.Count; i++)
            arr1[i] = arr[i].Length;
        result = arr1.Max();
        return result;
    }
}
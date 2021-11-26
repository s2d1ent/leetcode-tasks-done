public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        string val_str = "";
        foreach(var i in digits)
            val_str+=i;
        val_str = (BigInteger.Parse(val_str) + 1).ToString();
        int[] res = new int[val_str.Length];
        for(var i = 0; i < res.Length; i++)
        {
            res[i] = int.Parse($"{val_str[i]}");
        }
        return res;
    }
}
public class Solution 
{
    public int Reverse(int x) 
    {
        string s = x.ToString();
        string rev = "";
        for(var i = s.Length - 1; i > -1; i--)
            rev += s[i];
        rev = rev.Replace("-","");
        if(x < 0)
            rev = "-"+rev;
        if(!Int32.TryParse(rev, out var res))
            rev = "0";
        return Convert.ToInt32(rev);
    }
}
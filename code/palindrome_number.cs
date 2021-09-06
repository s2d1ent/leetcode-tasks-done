public class Solution {
    string s;
    public bool IsPalindrome(int x) {
        char[] X = new char[x.ToString().Length];
        for(var i = 0; i<x.ToString().Length; i++)
        {
            var index = x.ToString().Length - i - 1;
            X[i] = x.ToString()[index];
        }
        for(var i=0;i < x.ToString().Length;i++)
            s += X[i];
        if(x.ToString() == s)
            return true;
        else return false;
    }
}

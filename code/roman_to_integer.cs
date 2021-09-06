public class Solution
{
    string[] rome = new string[] { "I", "V", "X", "L", "C", "D", "M" };
    string[] rome1 = new string[] {"IV", "IX", "XL", "XC", "CD", "CM"};
    int[] arabian = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
    int[] arabian1 = new int[] { 4, 9, 40, 90, 400, 900 };
    public int RomanToInt(string s)
    {
        int result = 0;

        for (var i = 0; i < rome1.Length; i++)
        {
            if (s.IndexOf(rome1[i]) != -1)
            {
                s = s.Replace(rome1[i], "");
                result += arabian1[i];
            }
        }
        for (var i = 0; i < s.Length; i++)
        {
            for (var j = rome.Length - 1; j > -1; j--)
            {
                if (Convert.ToString(s[i]) == rome[j])
                {
                    result += arabian[j];
                }
            }
        }
        return result;
    }
}

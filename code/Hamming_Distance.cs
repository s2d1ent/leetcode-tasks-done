public class Solution {
    delegate void place(string x, string y);
    public int HammingDistance(int x, int y) {
        int result = 0;
        string[] bin = new string[]{Binary(x), Binary(y)};
        place p = (a, b) => { bin[0] = b; bin[1] = a;};
        if(bin[1].Length < bin[0].Length)
        {
            p(bin[0], bin[1]); 
            while(bin[1].Length != bin[0].Length )
                bin[0] = $"0{bin[0]}";   
        }
        else
            while(bin[1].Length != bin[0].Length )
                bin[0] = $"0{bin[0]}";
        for(var i = 0; i < bin[0].Length; i++)
            if(bin[0][i] != bin[1][i])
                result++;
        return result;
    }
    static string Binary(int input)
    {
        string gap = "";
        string result = "";
        int Out = input;
        while (Out > 0)
        {
            var remain = Out % 2;
            gap += remain;
            Out /= 2;
        }
        for(var i = gap.Length - 1; i > -1; i--)
            result += gap[i];
        return result;
    }
}
public class Solution {
    public int[] SingleNumber(int[] nums)
    {
        int length = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for (var j = 0; j < nums.Length; j++)
                if (nums[i] == nums[j])
                    count++;
            if(count == 1)
                length++;
        } 
        int[] result = new int[length];
        bool[] resultWrite = new bool[length];
        for (var i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for (var j = 0; j < nums.Length; j++)
                if (nums[i] == nums[j])
                    count++;
            for (var j = 0; j < result.Length; j++)
                if (count == 1)
                    if (result[j] == 0 && !resultWrite[j])
                    {
                        result[j] = nums[i];
                        resultWrite[j] = true;
                        break;
                    }
        }
        return result;
    }
}
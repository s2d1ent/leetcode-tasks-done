public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        List<int> result = new List<int>();
        int Result = 0;
        for(var i = 0; i < nums.Length; i++)
            {
            int count = 0;
            for(var j = 0; j < nums.Length; j++)
                {
                if(nums[i] == nums[j])
                    count++;
                  
                }
            result.Add(count);
            }
        for(var i = 0; i < result.Count; i++)
            if(result[i] == 1)
                Result = nums[i];
        return Result;
    }
}
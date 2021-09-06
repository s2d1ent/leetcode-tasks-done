public class Solution
{
    int a, b;
    public int[] TwoSum(int[] nums, int target)
    {
        for(var i = 0;i< nums.Length;i++)
        {
            for(var j = 0;j< nums.Length;j++)
            {
                if(nums[i]+nums[j] == target && j != i)
                {
                        a = i;
                        b = j;
                        break;
                }
                else
                    continue;
            }
        }
        return new int[]{a,b};  
    }
}

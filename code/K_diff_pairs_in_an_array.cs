public class Solution 
{
    public int FindPairs(int[] nums, int k) 
    {
        int result = 0;
        List<int> tempCollect = new();
        List<Numbers> buffer = new();
        
        foreach(int elem in nums) tempCollect.Add(elem);    
        for(int i = 0; i < tempCollect.Count; i++)
        {
            for(int j = 0; j < tempCollect.Count; j++)
            {
                if(i == j) continue;
                if(tempCollect[i] - tempCollect[j] == k) 
                {
                    Numbers temp = new(tempCollect[i], tempCollect[j]);
                    bool isHave = false;
                    foreach(Numbers elem in buffer) 
                    {
                        if(elem.x == temp.x && elem.y == temp.y) isHave = true;
                    }
                    if(!isHave)
                    {
                        buffer.Add(temp);
                        result++;
                    }
                }
            }    
        }
        
        return result;
    }
    
    struct Numbers
    {
        public int x;
        public int y;
        public Numbers(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
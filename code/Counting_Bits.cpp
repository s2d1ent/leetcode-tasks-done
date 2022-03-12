class Solution {
public:
    vector<int> countBits(int n) {
        vector<int> result;
        
        for(int i = 0; i < n + 1; i++)
        {
            int count = 0;
            string val = binSystem(i);
            result.push_back(val.length());
        }
        
        return result;
    }
    
    string binSystem(int value)
    {
        string result = "";
        
        while(true)
        {
            if(value % 2 == 1) result = to_string(value % 2) + result;
            value = (value - (value % 2)) / 2;
            if(value == 1 || value == 0)
            {
                if(value % 2 == 1) result = to_string(value) + result;
                break;
            }
        }
        
        return result;
    }
};
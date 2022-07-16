class Solution {
public:
    int evalRPN(vector<string>& tokens) {
        int result = 0;
        string signs = "+-*/";
        stack<string> stack;
        
        for(int i = 0; i < tokens.size(); i++)
        {
            string symbol = tokens[i];
            bool isNumber = intTryParse(symbol);
        
            if(isNumber)
            {
                stack.push(symbol);
            }
            
            for(int j = 0; j < signs.length(); j++)
            {
                if(isNumber)
                {
                    break;
                }
                string sign = "";
                sign += signs[j];
                
                if(sign == "+" && symbol == sign)
                {
                    int res = 0;
                    int x = 0;
                    int y = 0;
                    x = stoi(stack.top());
                    stack.pop();
                    y = stoi(stack.top());
                    stack.pop();
                    
                    res = add(x, y);
                    stack.push(to_string(res));
                }
                if(sign == "-" && symbol == sign)
                {
                    int res = 0;
                    int x = 0;
                    int y = 0;
                    x = stoi(stack.top());
                    stack.pop();
                    y = stoi(stack.top());
                    stack.pop();
                    
                    res = min(x, y);
                    stack.push(to_string(res));
                }
                if(sign == "*" && symbol == sign)
                {
                    int res = 0;
                    int x = 0;
                    int y = 0;
                    x = stoi(stack.top());
                    stack.pop();
                    y = stoi(stack.top());
                    stack.pop();
                    
                    res = mult(x, y);
                    stack.push(to_string(res));
                }
                if(sign == "/" && symbol == sign)
                {
                    int res = 0;
                    int x = 0;
                    int y = 0;
                    x = stoi(stack.top());
                    stack.pop();
                    y = stoi(stack.top());
                    stack.pop();
                    res = div(x, y);
                    stack.push(to_string(res));
                }
            }
        }
        
        if(!stack.empty())
        {
            result = stoi(stack.top());
        }
        
        return result;
    }
    
    int add(int x, int y)
    {
        return x + y;
    }
    
    int min(int x, int y)
    {
        return y - x;
    }
    
    int mult(int x, int y)
    {
        return x * y;
    }
    
    int div(int x, int y)
    {
        return y / x;
    }
    
    bool intTryParse(string str)
    {
        bool result = false;
        int x = 0;
        try
        {
            x = stoi(str);    
            result = true;
        }
        catch (exception ex)
        {
            return false;  
        }
        
        return result;
    }
};
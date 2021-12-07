class Solution {
public:
    int getDecimalValue(ListNode* head) 
    {
        vector<int> list;
        GetVal(head, &list);
        return GetOtherSystem(&list);
    }
    
    void GetVal(ListNode *node, vector<int> *list)
    {
        if(node == nullptr)
        {
            delete node;
            delete list;
            return;
        }   
	    list->push_back(node->val);
	    if(node->next != nullptr)
		    GetVal(node->next, list);
    }
    int GetOtherSystem(vector<int> *list)
    {
        int result = 0;
        int index = 0;
        int arr_index[list->size()];
        for(int i = list->size() - 1; i > -1; i--)
        {
            arr_index[i] = index;
            index++;
        } 
        for(int i = 0; i < list->size(); i++)
        {
            result += list->at(i) * pow(2, arr_index[i]);
        }
        return result;
    }
};
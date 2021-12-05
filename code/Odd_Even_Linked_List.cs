class Solution {
public:
    ListNode* oddEvenList(ListNode* head) {
        vector<int> list;
        vector<int> listend;
        vector<ListNode*> nodes;
        GetVal(head, &list);
        if(list.size() == 0)
            return head;
        for(int i = 0; i < list.size(); i++)
	        if(i%2==0)
                listend.push_back(list[i]);
        for(int i = 0; i < list.size(); i++)
	        if(i%2!=0)
                listend.push_back(list[i]);
        for(int i = 0; i < listend.size(); i++)
            nodes.push_back(new ListNode(listend.at(i)));
        for(int i = nodes.size()-1; i > -1 ; i--)
            if(i - 1 > -1)
                nodes[i-1]->next = nodes[i];
        return nodes[0];
    }
    void GetVal(ListNode *node, vector<int> *list)
    {
        if(node == nullptr)
            return;
	    list->push_back(node->val);
	    if(node->next != nullptr)
		    GetVal(node->next, list);
    }
};
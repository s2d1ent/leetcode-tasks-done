struct tree
{
    int val = 0;
    int count = 0;
    
    tree* left;
    tree* right;

    tree() : left(NULL), right(NULL), val(0), count(0){}
};

class Solution {
public:
    ListNode* mergeKLists(vector<ListNode*>& lists) {
        ListNode* result;
        tree* node;
        if(lists.size() == 0)
        {
            return nullptr;
        }
        node = getTree(&lists);
        
        if(!node)
        {
            return nullptr;
        }
        result = getNode(node);     
        return result;
    }
    
    ListNode* getLastNode(ListNode* node)
    {
        ListNode* res = node;
        ListNode* tmp = node;
    
        while(tmp != nullptr)
        {
            res = tmp;
            tmp = tmp->next;
            if(res == tmp) break;
        }
        
        tmp = NULL;
        delete tmp;
        return res;
    }
    
    ListNode* getNode(tree* node)
    {
        ListNode* result;
        ListNode* left;
        ListNode* right;
    
        if(!node)
        {
            return nullptr;
        }
    
        result = new ListNode;
        result->val = node->val;
        --(node->count);
        left = result;
        while((node->count--) > 0)
        {
            left->next = new ListNode;
            left->next->val = node->val;
            left = left->next;
        }
        left = (node->left != nullptr) ? getNode(node->left) : nullptr;
        right = (node->right != nullptr) ? getNode(node->right) : nullptr;
        
    
        if(left != nullptr)
        {
            ListNode* last = getLastNode(left);
            last->next = result;
            result = left;
    
            last = NULL;
            delete last;
        }
    
        if(right != nullptr)
        {
            ListNode* last = getLastNode(result);
            last->next = right;
    
            last = NULL;
            delete last;
        }
    
        return result;
    }
    
    tree* getTree(vector<ListNode*>* list)
    {
        ListNode* tmp;
        tree* res = NULL;
        for(int i = 0; i < (*list).size(); ++i)
        {
            tmp = (*list)[i];
            if(!tmp) continue;
            while(tmp != nullptr)
            {
                if(!res)
                {
                    res = new tree;
                    res->val = tmp->val;
                }
                setTree(tmp->val, res);
                tmp = tmp->next;
            }
            if(!tmp)
            {
                free(tmp);
            }
        }
        return res;
    }
    
    void setTree(int val, tree* node)
    {
        if(!node)
        {
            return;
        }
        if(node->val == val)
        {
            ++(node->count);
        }
        else if(node->val > val)
        {
            if(!node->left)
            {
                node->left = new tree;
                node->left->val = val;
                ++(node->left->count);
            }
            else
            {
                setTree(val, node->left);
            }
        }
        else
        {
            if(!node->right)
            {
                node->right = new tree;
                node->right->val = val;
                ++(node->right->count);
            }
            else
            {
                setTree(val, node->right);
            }
        }
    }
};
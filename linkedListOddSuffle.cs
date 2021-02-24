/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    /** they want me to shufflyu a linked list
        put odds first, then evens
        constratins
        o1 space and on time
        ther is an off by on - where head is 1 not 0
        input the head of linked list
        output head of linked list
        data structure is th LL
    **/
    ListNode* oddEvenList(ListNode* head) {
            // Corner case  
        if (head == NULL)  
            return NULL;  
  
        // Initialize first nodes of even and  
        // odd lists  
        ListNode *odd = head;  
        ListNode *even = head->next;  
  
        // Remember the first node of even list so  
        // that we can connect the even list at the  
        // end of odd list.  
        ListNode *evenFirst = even;  
  
        while (1 == 1)  
        {  
            // If there are no more nodes,  
            // then connect first node of even  
            // list to the last node of odd list  
            if (odd == NULL || even == NULL ||  
                            (even->next) == NULL)  
            {  
                odd->next = evenFirst;  
                break;  
            }  
  
            // Connecting odd nodes  
            odd->next = even->next;  
            odd = even->next;  
  
            // If there are NO more even nodes  
            // after current odd.  
            if (odd->next == NULL)  
            {  
                even->next = NULL;  
                odd->next = evenFirst;  
                break;  
            }  
  
            // Connecting even nodes  
            even->next = odd->next;  
            even = odd->next;  
        }  
        return head;  
            
    }
};

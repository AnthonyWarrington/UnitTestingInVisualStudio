using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
        public DLList() { head = null;  tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        public void addToTail(DLLNode p)
        {

            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                tail = p;
                p.previous = tail;
            }
        } // end of addToTail

        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = this.head;
                this.head.previous = p;
                head = p;
            }
        } // end of addToHead

        public void removeHead()
        {
            if (head == null) return;
            // corrected this code so that when head is removed,
            // next node becomes head & next node.previous is null
            else if (head != tail)
            {
                head = head.next;
                head.previous = null;
            }

            else //only 1 node in the list
            {
                head = null;
                tail = null;
            }
        } // removeHead

        public void removeTail()
        {
            // corrected this code so that when tail is removed,
            // the previous node becomes the tail
            if (head == null)
            {
                return;
            }
            else if (head != tail)
            {
                tail = tail.previous;
                tail.next = null;
            }
            else
            {
                head = null;
                tail = null;
            }
        } // remove tail


        /*-------------------------------------------------
         * Return null if the string does not exist.
         * ----------------------------------------------*/
        public DLLNode search(int num)
        {
            DLLNode p = head;
            // if list is null, return null
            if (p == null)
            {
                return null;
            }

            while (p != null)
            {
                if (p.num.Equals(num))
                {
                    return p; // Returns pointer to node                
                }
                p = p.next; // iterate through list AFTER checking num
            }
            return null; // If p is null after while loop, return null (no match)          

        } // end of search
            

        public void removeNode(DLLNode p)
        {
            DLLNode node = head;
            
            //base case (empty list)
            if (head == null)
            {
                return;
            }

            //find the node
            while (node.num != p.num)
            {
                if (node.next == null)
                {
                    return; //node doesn't exist
                }
                else
                {
                    node = node.next;
                }
            }

            //1 node list
            if (node == head && node == tail) {
                head = null;
                tail = null;
            } else if (node == head)

            //node is head
            {
                head = head.next;
                head.previous = null;
            } else if (node == tail)

            //node is tail
            {
                tail = tail.previous;
                tail.next = null;
            } else

            //node is neither head nor tail
            {
                node.next.previous = node.previous;
                node.previous.next = node.next;
            }
        } // end of removeNode()

        public int total()
        {
            DLLNode p = head;
            int total = 0;
            while (p != null)
            {
                total ++;
                p = p.next;
            }
            return (total);
        } // end of total
    } // end of DLList class
}

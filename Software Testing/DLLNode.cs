using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLLNode
    {
        public int num;   // field of the node
        public DLLNode next; // pointer to the next node
        public DLLNode previous; // pointer to the previous node
        public DLLNode (int num)
        {
            this.num = num;
            next = null;
            previous = null;
        } // end of constructor

        //Method to determine if a number is prime or not
        public bool isPrime(int n)
        {
            Boolean primeBool = true;

            // returns 1 as false because its not a prime number
            if (n == 1) 
                primeBool = false;

            // returns 2 as true because its a prime number
            if (n == 2)             
                primeBool = true;            

            // if n divisible by 2 then its not a prime number
            if ((n % 2) == 0 && (n != 2))            
                primeBool = false;          

            // calculate square root outside of loop for optimisation
            double a = Math.Sqrt(n); 

            // for-loop increments i by 2 from 3 to only check odd numbers for optimisation
            for (int i = 3; i <= a; i += 2)
            {
                if (n % i == 0)
                {
                    primeBool = false;
                    break;
                }
            }
            return primeBool;
        }

    } // end of class DLLNode
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListWithErrors;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // 1. Testing DLList.total()
        // I tested & fixed this first so I could use the method
        // (once it was corrected) to do more testing below
        [TestMethod]
        public void TestTotal1()
        {
            DLList myDLL = new DLList();
            Assert.AreEqual(myDLL.total(), 0);
        }

        // 2. Testing DLList.addToTail() to cover when head == null
        [TestMethod]
        public void TestAddToTail1()
        {
            DLList myDLL = new DLList();
            DLLNode p = new DLLNode(1);
            myDLL.addToTail(p);
            Assert.AreEqual(myDLL.total(), 1);
        }

        // 3. Testing DLList.addToTail() to cover when head != null
        // and to check that q is inserted at the tail
        [TestMethod]
        public void TestAddToTail2()
        {
            DLList myDLL = new DLList();
            DLLNode p = new DLLNode(1);
            myDLL.addToTail(p);
            DLLNode q = new DLLNode(2);
            myDLL.addToTail(q);
            Assert.AreEqual(q, myDLL.tail); ; //check that tail value == 2
        }

        // 4. This test case was done after assuring addToTail() works
        [TestMethod]
        public void TestTotal2()
        {
            DLList myDLL = new DLList();
            DLLNode p = new DLLNode(1);
            myDLL.addToTail(p);
            DLLNode q = new DLLNode(2);
            myDLL.addToTail(q);
            DLLNode r = new DLLNode(3);
            myDLL.addToTail(r);
            DLLNode s = new DLLNode(4);
            myDLL.addToTail(s);
            DLLNode t = new DLLNode(-7);
            myDLL.addToTail(t);

            Assert.AreEqual(myDLL.total(), 5);
        }

        // 5. Testing DLList.addToHead() for when head == null
        [TestMethod]
        public void TestAddToHead1()
        {
            DLList myDLL = new DLList();
            DLLNode p = new DLLNode(1);
            myDLL.addToHead(p);
            Assert.AreEqual(myDLL.total(), 1);
        }

        // 6. Testing DLList.addToHead() to cover when head != null
        // and to check that q is inserted at the head
        [TestMethod]
        public void TestAddToHead2()
        {
            DLList myDLL = new DLList();
            DLLNode p = new DLLNode(1);
            myDLL.addToHead(p);
            DLLNode q = new DLLNode(2);
            myDLL.addToHead(q);
            Assert.AreEqual(q, myDLL.head); //check that head node is q
        }

        // 7. Coverage for list with no nodes where head should == null
        [TestMethod]
        public void TestRemoveHead1()
        {
            DLList myDLL = new DLList();
            myDLL.removeHead();
            Assert.AreEqual(myDLL.head, null);
        }

        // 8. Coverage for removing head in DLL of 3 nodes
        [TestMethod]
        public void TestRemoveHead2()
        {
            DLList myDLL = new DLList();
            DLLNode p = new DLLNode(1);
            myDLL.addToHead(p);
            DLLNode q = new DLLNode(2);
            myDLL.addToHead(q);
            DLLNode r = new DLLNode(3);
            myDLL.addToHead(r);

            myDLL.removeHead();

            // When removing head (3) from DLL (3,2,1) new head should be 2
            Assert.AreEqual(myDLL.head.num, 2);
        }

        // 9. Coverage for removing head in DLL of 1 node
        [TestMethod]
        public void TestRemoveHead3()
        {
            DLList myDLL = new DLList();
            DLLNode p = new DLLNode(1);
            myDLL.addToHead(p);

            myDLL.removeHead();

            // When removing head (1) from DLL (1) new head & tail should be null
            Assert.AreEqual(myDLL.head, null);
            Assert.AreEqual(myDLL.tail, null);
        }

        // 10. Coverage for list with no nodes where tail should == null
        [TestMethod]
        public void TestRemoveTail1()
        {
            DLList myDLL = new DLList();
            myDLL.removeTail();
            Assert.AreEqual(myDLL.tail, null);
        }

        // 11. Coverage for removing tail in DLL of 3 nodes
        [TestMethod]
        public void TestRemoveTail2()
        {
            DLList myDLL = new DLList();
            DLLNode p = new DLLNode(1);
            myDLL.addToHead(p);
            DLLNode q = new DLLNode(2);
            myDLL.addToHead(q);
            DLLNode r = new DLLNode(3);
            myDLL.addToHead(r);

            myDLL.removeTail();

            // When removing tail (1) from DLL (3,2,1) new head should be 2
            Assert.AreEqual(myDLL.tail.num, 2);
        }

        // 12. Coverage for removing tail in DLL of 1 node
        [TestMethod]
        public void TestRemoveTail3()
        {
            DLList myDLL = new DLList();
            DLLNode p = new DLLNode(1);
            myDLL.addToHead(p);

            myDLL.removeTail();

            // When removing tail (1) from DLL (1) new head & tail should be null
            Assert.AreEqual(myDLL.head, null);
            Assert.AreEqual(myDLL.tail, null);
        }

        // 13. Tests for a value in the list
        [TestMethod]
        public void TestSearch1()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(5);
            DLLNode node2 = new DLLNode(4);
            DLLNode node3 = new DLLNode(3);
            DLLNode node4 = new DLLNode(2);
            DLLNode node5 = new DLLNode(7);

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);
            list.addToHead(node4);
            list.addToHead(node5);

            //Searching value 7 should == pointer to node5
            Assert.AreEqual(list.search(7), node5);
        }

        // 14. Tests searching an empty list
        [TestMethod]
        public void TestSearch2()
        {
            DLList list = new DLList();
            Assert.IsNull(list.search(1));
        }

        // 15. Test search for node that doesn't exist
        [TestMethod]
        public void TestSearch3()
        {
            DLList list = new DLList();

            DLLNode node1 = new DLLNode(5);
            DLLNode node2 = new DLLNode(4);
            DLLNode node3 = new DLLNode(3);
            DLLNode node4 = new DLLNode(2);
            DLLNode node5 = new DLLNode(7);

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);
            list.addToHead(node4);
            list.addToHead(node5);

            Assert.IsNull(list.search(1));
        }

        // 16. Test removing middle node from list of five
        [TestMethod]
        public void TestRemoveNode1()
        {
            DLList list = new DLList();

            DLLNode node1 = new DLLNode(5);
            DLLNode node2 = new DLLNode(4);
            DLLNode node3 = new DLLNode(3);
            DLLNode node4 = new DLLNode(2);
            DLLNode node5 = new DLLNode(7);

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);
            list.addToHead(node4);
            list.addToHead(node5);

            list.removeNode(node3);

            // there should only be 4 nodes left and value
            // of 7 should not be present
            Assert.AreEqual(list.total(), 4);
            Assert.IsNull(list.search(3));
        }

        // 17. Test removing one node from list of one
        [TestMethod]
        public void TestRemoveNode2()
        {
            DLList list = new DLList();

            DLLNode node1 = new DLLNode(5);
            list.addToHead(node1);

            list.removeNode(node1);

            Assert.AreEqual(list.total(), 0);
            Assert.IsNull(list.search(5));
        }

        // 18. Test removing node from empty list
        [TestMethod]
        public void TestRemoveNode3()
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(5);

            list.removeNode(node1);
        }

        // 19. Test removing head from list of five (7,2,3,4,5)
        [TestMethod]
        public void TestRemoveNode4()
        {
            DLList list = new DLList();

            DLLNode node1 = new DLLNode(5);
            DLLNode node2 = new DLLNode(4);
            DLLNode node3 = new DLLNode(3);
            DLLNode node4 = new DLLNode(2);
            DLLNode node5 = new DLLNode(7);

            list.addToHead(node1); //tail
            list.addToHead(node2);
            list.addToHead(node3);
            list.addToHead(node4);
            list.addToHead(node5); //head

            list.removeNode(node5);

            // there should only be 4 nodes left
            // value of 7 should not be present
            // head should be node 4
            Assert.AreEqual(list.total(), 4);
            Assert.IsNull(list.search(7));
            Assert.AreEqual(list.head, node4);
        }

        // 20. Test removing tail from list of five (7,2,3,4,5)
        [TestMethod]
        public void TestRemoveNode5()
        {
            DLList list = new DLList();

            DLLNode node1 = new DLLNode(5); //tail
            DLLNode node2 = new DLLNode(4);
            DLLNode node3 = new DLLNode(3);
            DLLNode node4 = new DLLNode(2);
            DLLNode node5 = new DLLNode(7); //head

            list.addToHead(node1);
            list.addToHead(node2);
            list.addToHead(node3);
            list.addToHead(node4);
            list.addToHead(node5);

            list.removeNode(node1);

            // there should only be 4 nodes left
            // value of 5 should not be present
            // head should be node 2
            Assert.AreEqual(list.total(), 4);
            Assert.IsNull(list.search(5));
            Assert.AreEqual(list.tail, node2);
        }

        // 21. Prime number test: 1 (edge-case)
        [TestMethod]
        public void TestPrime1()
        {
            DLLNode node = new DLLNode(1);
            Assert.IsFalse(node.isPrime(node.num));
        }

        // 21. Prime number test: 2 (edge-case)
        [TestMethod]
        public void TestPrime2()
        {
            DLLNode node = new DLLNode(2);
            Assert.IsTrue(node.isPrime(node.num));
        }

        // 22. Prime number test: 200 (no prime number is an even number except for 2)
        [TestMethod]
        public void TestPrime3()
        {
            DLLNode node = new DLLNode(200);
            Assert.IsFalse(node.isPrime(node.num));
        }

        // 23. Prime number test: 97 to check it returns true
        [TestMethod]
        public void TestPrime4()
        {
            DLLNode node = new DLLNode(97);
            Assert.IsTrue(node.isPrime(node.num));
        }
    }
}

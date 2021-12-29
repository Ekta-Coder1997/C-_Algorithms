using System;
using System.Collections.Generic;
 
class Program 
{ 
        public Node head;
 
   
    public class Node 
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
 
    
    public void push(int new_data)
    {
        
        Node new_node = new Node(new_data);
 
        
        new_node.next = head;
 
        
        head = new_node;
    }
 
    
    public static bool detectLoop(Node h)
    {
        HashSet<Node> s = new HashSet<Node>();
        while (h != null) {
            
            if (s.Contains(h))
                return true;
 
            
            s.Add(h);
 
            h = h.next;
        }
 
        return false;
    }
 
    
    public static void Main(String[] args)
    {
        Program llist = new Program();
 
        llist.push(19);
        llist.push(15);
        llist.push(20);
        llist.push(10);
 
        
        llist.head.next.next.next.next = llist.head;
 
        if (detectLoop(llist.head))
            Console.WriteLine(" It is a Cyclic List ");
        else
            Console.WriteLine(" It is not a Cyclic List");
    }
}
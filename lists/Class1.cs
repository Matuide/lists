using System;
using System.Collections.Generic;
using System.Text;

namespace lists
{
    class List1
    {
        private Node head;
        public List1()
        {
head = null;
        }
            
public void addList(string name)
        {
        Node temp;
        temp = new Node();
            Node n;
            n = new Node();
            n.name = name;
            n.next = null;
            temp.name = name;
            temp = head;
            if (temp == null)
            {
                head = n;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = n;
            }


           
        }
        public void PrintList()
        {

        }

    }
        
}

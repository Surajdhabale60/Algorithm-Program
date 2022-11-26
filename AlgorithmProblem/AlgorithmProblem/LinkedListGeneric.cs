using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class LinkedListGeneric<T>
    {
        int count = 0;
        public Node<T> head;
        public void AddLast(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
                count++;

            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                count++;
            }
        }
        public void SearchDelete(T value)
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            if (count == 1)
            {
                head = null;
                count--;
                return;
            }
            Node<T> previousNode = head;
            Node<T> temp = head.next;
            while (previousNode != null)
            {
                if(previousNode.data.Equals(value))
                {
                    temp.next = previousNode.next;
                    previousNode = null;
                    count--;
                    return;
                }
                temp = previousNode;
                previousNode = previousNode.next;
            }
        }
        public void Display()
        {           
            if (head == null)
            {
                Console.WriteLine("Linked list empty");
                return;
            }
            while (head != null)
            {
                Console.WriteLine(head.data + "");
                head = head.next;
            }
            Console.WriteLine("null");
        }

    }
}

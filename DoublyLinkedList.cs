using System;
using System.Collections.Generic;
using System.Collections;

namespace HW_Generics
{
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }
    public class DoublyLinkedList<T>
    {
        DoublyNode<T> head;
        DoublyNode<T> tail;
        int? count;

        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            if(head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            else
                temp.Previous = node;
            count++;
        }

        public bool Remove(T data)
        {
            DoublyNode<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }

        public int Count { get { return (int)count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            count = 0;
            head = null;
            tail = null;
        }

        public bool Contains(T data)
        {
            DoublyNode<T> current = head;
            while(current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                    current = current.Next;
                }
            }
            return false;
        }
    }
}

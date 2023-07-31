using System;
using System.Collections;
using System.Collections.Generic;

namespace Tutoring;

public class Node<T>
{
    public T Value;
    public Node<T> Next;

    public Node(T value)
    {
        Value = value;
    }
}

public class MyLinkedList<T>: IEnumerable<T>
{
    public Node<T> Head { get; set; }
    public Node<T> Tail { get; set; }
    
    public int Count { get; set; }

    public void Add(T value)
    {
        var node = new Node<T>(value);
        if (Head == null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Head.Next = node;
            Head = node;
        }

        Count++;
    }

    public void Delete(T value)
    {
        var currentNode = Tail;
        Node<T> previousNode = null;

        while (currentNode != null)
        {
            if (currentNode.Value.Equals(value))
            {
                if (previousNode == null)
                {
                    Tail = Tail.Next;

                    if (Tail == null)
                        Head = null;
                }
                else
                {
                    previousNode.Next = currentNode.Next;

                    if (previousNode.Next == null)
                        Head = previousNode;
                }
                
                
                
                break;
            }
            else
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
        }
        

    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = Tail;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
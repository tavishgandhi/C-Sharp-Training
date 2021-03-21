using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class PriorityQueue1<T> where T : IEquatable<T>
    {

            private IDictionary<int, Queue<T>> elements;
            private int size;
            bool isMinPriorityQueue;

            // Default Constructor
            public PriorityQueue1()
            {
                elements = new Dictionary<int, Queue<T>>();
                size = 0;
                isMinPriorityQueue = false;
            }

            // Parametrised Constructor
            public PriorityQueue1(IDictionary<int, IList<T>> elements, bool MinProrityQueue = false) : this()
            {
                foreach (int element in elements.Keys)
                {
                    Queue<T> q = new Queue<T>();
                    if (elements[element] is not null)
                    {
                        foreach (T item in elements[element])
                        {
                            q.Enqueue(item);
                        }
                        this.elements.Add(element, q);
                        this.size += elements[element].Count;
                    }
                }

                this.isMinPriorityQueue = MinProrityQueue;
            }

            // Count function - returning count of priority queue
            public int Count()
            {
                return this.size;
            }

            // Whether priority queue contains the given element
            public bool Contains(T item)
            {
                foreach (int element in elements.Keys)
                {
                    Queue<T> queue = elements[element];
                    foreach (T reqItem in queue)
                    {
                        if (reqItem.Equals(item))
                            return true;
                    }
                }
                return false;
            }

            // Dequeue
            public T Dequeue()
            {
                if (this.size == 0)
                    throw new Exception("priority Queue is empty.");

                int max = GetHighestPriority();
                Queue<T> q = elements[max];
                if (q.Count == 0)
                {
                    throw new Exception("Empty queue");
                }
                T dequedElement = q.Dequeue();
                this.size--;
                // If all elements of list are dequed
                if (elements[max].Count == 0)
                {
                    elements.Remove(max);
                }
                return dequedElement;

            }
            public void Enqueue(int priority, T item)
            {
                Queue<T> queue;
                this.size++;

                if (this.elements.ContainsKey(priority))
                {
                    queue = elements[priority];
                    queue.Enqueue(item);
                }
                else
                {
                    queue = new Queue<T>();
                    queue.Enqueue(item);
                    elements.Add(priority, queue);
                }

            }

            public T Peek()
            {
                int maxPriority = GetHighestPriority();
                T item = elements[maxPriority].Peek();
                return item;
            }

            private int GetHighestPriority()
            {
                var list = elements.Keys;
                int max;
                if (this.isMinPriorityQueue)
                {
                    max = list.Min();
                }
                else
                {
                    max = list.Max();
                }

                return max;
            }

    }
}

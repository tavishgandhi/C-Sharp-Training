using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class PriorityQueue<T> where T : IEquatable<T>
    {
        private IDictionary<int, IList<T>> elements;
        private int size;
        bool isMinPriorityQueue;

        // Default Constructor
        public PriorityQueue()
        {
            elements = new Dictionary<int, IList<T>>();
            size = 0;
            isMinPriorityQueue = false;
        }
        // Parametrised Constructor
        public PriorityQueue(IDictionary<int, IList<T>> elements, bool MinProrityQueue = false):this ()
        {
            this.elements = elements;
            foreach(T item in elements.Values)
            {

            }
            this.size = elements.Count;
            this.isMinPriorityQueue = MinProrityQueue;
        }

        private void MaxHeapify(int i)
        {
            int left = i * 2 + 1;
            int right = i * 2 + 2;

            int heighst = i;

            if (left <= heapSize && queue[heighst].Priority < queue[left].Priority)
                heighst = left;
            if (right <= heapSize && queue[heighst].Priority < queue[right].Priority)
                heighst = right;

            if (heighst != i)
            {
                Swap(heighst, i);
                MaxHeapify(heighst);
            }
        }
        private void MinHeapify(int i)
        {
            int left = ChildL(i);
            int right = ChildR(i);

            int lowest = i;

            if (left <= heapSize && queue[lowest].Priority > queue[left].Priority)
                lowest = left;
            if (right <= heapSize && queue[lowest].Priority > queue[right].Priority)
                lowest = right;

            if (lowest != i)
            {
                Swap(lowest, i);
                MinHeapify(lowest);
            }
        }
        // Count function - returning count of priority queue
        public int Count()
        {
            return this.size;
        }

        // Whether priority queue contains the given function
        public bool Contains(T item)
        {
            foreach(List<T> element in elements.Values)
            {
                if (item.Equals(element))
                {
                    return true;
                }
            }
            return false;

        }


// Dque ----------------------------------------------------------------
        private void MaxHeapify(int heapSize, List<T> list, int i)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            int heighst = i;

            T maxChild =  
            if (left <= heapSize && list[i] < list[left])
                heighst = left;
            if (right <= heapSize && queue[heighst].Priority < queue[right].Priority)
                heighst = right;

            if (heighst != i)
            {
                Swap(heighst, i);
                MaxHeapify(heighst);
            }
        }
        private void MinHeapify(int i)
        {
            int left = ChildL(i);
            int right = ChildR(i);

            int lowest = i;

            if (left <= heapSize && queue[lowest].Priority > queue[left].Priority)
                lowest = left;
            if (right <= heapSize && queue[lowest].Priority > queue[right].Priority)
                lowest = right;

            if (lowest != i)
            {
                Swap(lowest, i);
                MinHeapify(lowest);
            }
        }
        // Dequeue
        public T Dequeue()
        {
            if (this.size == 0)
                throw new Exception("priority Queue is empty.");
            else
            {
                // getting the max priority list elements 
                int maxPriority = GetHighestPriority();
                var maxPriorityList = (List<T>)elements[maxPriority];

                // dequed element
                var dequedElement = maxPriorityList[0];

                maxPriorityList[0] = maxPriorityList[maxPriorityList.Count];
                maxPriorityList.RemoveAt(maxPriorityList.Count);
                this.size--;

                // List of given particular priority is empty and thus removed
                if(maxPriorityList.Count == 0)
                {
                    elements.Remove(maxPriority);
                }
                else
                {
                    int heapSize = maxPriorityList.Count;
                    int i = 0;
                    if (!isMinPriorityQueue)
                    {
                        MaxHeapify(maxPriorityList.Count, maxPriorityList, i );
                    }
                    else
                        MaxHeapify(0);
                }
                
                //Maintaining lowest or highest at root based on min or max queue
                
                return dequedElement;
            }
        }
        public void Swap(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }


        public void Enqueue(int priority, T item)
        {
            this.size++;
            if (elements.ContainsKey(priority))
            {
                List<T> list = (List<T>)elements[priority];
                int heapsize = list.Count;

                if (this.isMinPriorityQueue)
                {
                    
                    while (heapsize >= 0 && list[(heapsize - 1) / 2] > list[heapsize])
                    {
                        Swap(list, heapsize, (heapsize - 1) / 2);
                        heapsize = (heapsize - 1) / 2;
                    }
                }
                else
                {
                    while (heapsize >= 0 && list[(heapsize - 1) / 2] < list[heapsize])
                    {
                        Swap(list, heapsize, (heapsize - 1) / 2);
                        heapsize = (heapsize - 1) / 2;
                    }
                }
            }
            else
            {
                List<T> list = new List<T>();
                list.Add(item);
                elements.Add(priority, list);
            }            
        }

        public T Peek()
        {
            int maxPriority = GetHighestPriority();


        }

        private int GetHighestPriority()
        {
            var list = elements.Keys;
            int max = Int32.MinValue;
            foreach(int priority in list)
            {
                max = Math.Max(priority, max);
            }
            return max;
        }

    }

}

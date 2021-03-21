using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    
    public interface IPriority
    {
        public int Priority { get; set; }
    }

    public class PriorityQueue2<T> where T: IEquatable<T>, IPriority
    {
        private IDictionary<int, IList<T>> elements;
        private int size;
        bool isMinPriorityQueue;

        public PriorityQueue2(bool isMinPriorityQueue = false)
        {
            elements = new Dictionary<int, IList<T>>();
            size = 0;
            
        }

        public PriorityQueue2(IEnumerable<T> elements, bool isMinPriorityQueue = false) :this()
        {
            this.isMinPriorityQueue = isMinPriorityQueue;
            foreach(var item in elements)
            {
                int priority = item.Priority;
                if (this.elements.ContainsKey(priority))
                {
                    List<T> list = (List<T>)this.elements[priority];
                    this.Enqueue( item);
                }
                else
                {
                    IList<T> list = new List<T>();
                    this.Enqueue(item);
                }
                this.size++;
            }

        }

        private void Swap(List<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        private int ChildL(int i)
        {
            return i * 2 + 1;
        }

        private int ChildR(int i)
        {
            return i * 2 + 2;
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
                List<T> queue = (List<T>)elements[element];
                foreach (T reqItem in queue)
                {
                    if (reqItem.Equals(item))
                        return true;
                }
            }
            return false;
        }

        // Dequeue
        private void MaxHeapify(List<T> list, int position)
        {
            int left = ChildL(position);
            int right = ChildR(position);
            int heapSize = list.Count - 1;
            int heighest = position;

            if (left <= heapSize && list[heighest].Priority < list[left].Priority)
                heighest = left;
            if (right <= heapSize && list[heighest].Priority < list[right].Priority)
                heighest = right;

            if (heighest != position)
            {
                Swap(list, heighest, position);
                MaxHeapify(list, heighest);
            }
        }
        private void MinHeapify(List<T> list, int position)
        {
            int heapSize = list.Count -1;
            int left = ChildL(position);
            int right = ChildR(position);

            int lowest = position;

            if (left <= heapSize && list[lowest].Priority > list[left].Priority)
                lowest = left;
            if (right <= heapSize && list[lowest].Priority > list[right].Priority)
                lowest = right;

            if (lowest != position)
            {
                Swap(list,lowest, position);
                MinHeapify(list, lowest);
            }
        }
        public T Dequeue()
        {
            if (this.size > 0)
            {
                int max = GetHighestPriority();
                List<T> list = (List<T>)this.elements[max];
                int heapSize = list.Count - 1;
                if (heapSize > 0)
                {
                    T reqElement;
                    reqElement = list[0];
                    list[0] = list[heapSize];
                    list.RemoveAt(heapSize);
                    this.size--;

                    if (list.Count == 0)
                    {
                        this.elements.Remove(max);
                    }
                    else
                    {
                        //Maintaining lowest or highest at root based on min or max queue
                        if (isMinPriorityQueue)
                            MinHeapify(list, 0);
                        else
                            MaxHeapify(list, 0);
                    }
                    return reqElement;
                }
                else
                    throw new Exception("List is empty.");
                
            }
            else
                throw new Exception("Queue is empty");

        }

        // Enqueue
        private void BuildHeapMax(List<T> list, int position)
        {
            while (position >= 0 && list[(position - 1) / 2].Priority < list[position].Priority)
            {
                Swap(list, position, (position - 1) / 2);
                position = (position - 1) / 2;
            }
        }
        private void BuildHeapMin(List<T> list, int psoition)
        {
            while (psoition > 0 && list[(psoition - 1) / 2].Priority > list[psoition].Priority)
            {
                Swap(list, psoition, (psoition - 1) / 2);
                psoition = (psoition - 1) / 2;
            }
        }
        public void Enqueue(T item)
        {
            this.size++;
            int priority = item.Priority;

            if (this.elements.ContainsKey(priority))
            {
                List<T> list = (List<T>)elements[priority];
                list.Add(item);
                int heapsize = list.Count -1;
                // Maintaining Heap
                if (!this.isMinPriorityQueue)
                {
                    BuildHeapMax(list, heapsize);
                }
                else
                    BuildHeapMin(list, heapsize);
            }
            else
            {
                List<T> list = new List<T>();
                list.Add(item);
                this.elements.Add(priority, list);
            }
        }

        public T Peek()
        {
            int max = GetHighestPriority();
            T reqElement = elements[max][0];
            return reqElement;
        }

        private int GetHighestPriority()
        {
            var list = this.elements.Keys;
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

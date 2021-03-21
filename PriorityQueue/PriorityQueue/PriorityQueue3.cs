using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class PriorityQueue3<T>where T:IEquatable<T>
    {

        private class PriorityNode
        {
            public int Priority { get; set; }
            public T data { get; private set; }

            public PriorityNode(int priority, T data)
            {
                this.Priority = priority;
                this.data = data;
            }
        }
        private IList<PriorityNode> elements;
        private int size;
        bool isMinPriorityQueue;
        public PriorityQueue3(bool isMinPriorityQueue = false )
        {
            elements = new List<PriorityNode>();
            size = 0;
            isMinPriorityQueue = false;

        }

        public PriorityQueue3(IDictionary<int, IList<T>> elements, bool isMinPriorityQueue = false) : this()
        {
            this.isMinPriorityQueue = isMinPriorityQueue;
              foreach(int priority in elements.Keys)
              {
                List<T> list = (List<T>)elements[priority];
                foreach(T element in list)
                {
                    this.Enqueue(priority, element);
                    this.size++;
                }
              }
        }

        public int Count()
        {
            return this.size;
        }

        public bool Contains(T item)
        {
            foreach (PriorityNode node in this.elements)
                if (node.data.Equals(item))
                    return true;
            return false;
        }
        private void Swap(int i, int j)
        {
            var temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
        // Dequeue
        private void MaxHeapify(int position)
        {
            int left = 2 * position + 1;
            int right = 2 * position + 2 ;

            int heapSize = elements.Count - 1;
            int heighest = position;

            if (left <= heapSize && this.elements[heighest].Priority < this.elements[left].Priority)
                heighest = left;
            if (right <= heapSize && this.elements[heighest].Priority < this.elements[right].Priority)
                heighest = right;

            if (heighest != position)
            {
                Swap( heighest, position);
                MaxHeapify( heighest);
            }
        }
        private void MinHeapify(int position)
        {
            int heapSize = elements.Count - 1;
            int left = 2 * position + 1;
            int right = 2 * position + 2;

            int lowest = position;

            if (left <= heapSize && this.elements[lowest].Priority > this.elements[left].Priority)
                lowest = left;
            if (right <= heapSize && this.elements[lowest].Priority > this.elements[right].Priority)
                lowest = right;

            if (lowest != position)
            {
                Swap(lowest, position);
                MinHeapify(lowest);
            }
        }
        public T Dequeue()
        {
            int heapSize = elements.Count - 1;
            if (this.size > 0)
            {
                T reqElement;
                reqElement = elements[0].data;
                this.elements[0] = this.elements[heapSize];
                elements.RemoveAt(heapSize);
                this.size--;

                //Maintaining lowest or highest at root based on min or max queue
                if (isMinPriorityQueue)
                    MinHeapify(0);
                else
                    MaxHeapify(0);
                   
                    return reqElement;
            }
            else
                throw new Exception("List is empty");

        }

        // Enqueue
        private void BuildHeapMax(int position)
        {
            while (position >= 0 && elements[(position - 1) / 2].Priority < elements[position].Priority)
            {
                Swap(position, (position - 1) / 2);
                position = (position - 1) / 2;
            }
        }

        private void BuildHeapMin(int position)
        {
            while (position >= 0 && elements[(position - 1) / 2].Priority > elements[position].Priority)
            {
                Swap(position, (position - 1) / 2);
                position = (position - 1) / 2;
            }
        }
        public void Enqueue(int Priority, T item)
        {
            PriorityNode node = new PriorityNode(Priority, item); 
            elements.Add(node);
            this.size++;

            int heapSize = elements.Count - 1;
            //Maintaining heap
            if (this.isMinPriorityQueue)
                BuildHeapMin(heapSize);
            else
                BuildHeapMax(heapSize);
        }


        public T Peek()
        {
            return elements[0].data;
        }

        private int GetHighestPriority()
        {
            return elements[0].Priority;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Priority Queueu with Way 1 : - ");
            PriorityQueue1<int> queue = new PriorityQueue1<int>();
            queue.Enqueue(1, 1);
            queue.Enqueue(2, 1);
            queue.Enqueue(1, 2);
            queue.Enqueue(1, 3);
            queue.Enqueue(3, 1);
            queue.Enqueue(4, 89);
            queue.Enqueue(4, 1);
            queue.Enqueue(3, 7);

            Console.WriteLine("Queue count  = "+ queue.Count());
            Console.WriteLine("Contains 3  = " + queue.Contains(3));
            Console.WriteLine("Peek = " + queue.Peek());

            Console.WriteLine("Dequed element  = " + queue.Dequeue());
            Console.WriteLine("Contains 7  = " + queue.Contains(7));
            Console.WriteLine("Contains 89  = " + queue.Contains(89));
            Console.WriteLine("Peek = " + queue.Peek());

            Console.WriteLine("------------------------------------------------ ");

            Console.WriteLine("Priority Queueu with Way 2 : - ");
            PriorityQueue2<Person> q2 = new PriorityQueue2<Person>();
            q2.Enqueue(new Person(1, "Tavish"));
            q2.Enqueue(new Person(2, "Anmol"));
            q2.Enqueue(new Person(1, "Gayatri"));
            q2.Enqueue(new Person(4 , "Guri"));
            q2.Enqueue(new Person(2, "Deevesh"));
            q2.Enqueue(new Person(2, " Coomon"));
            q2.Enqueue(new Person(4, "ttataol"));
            
            Console.WriteLine(q2.Count());
            Console.WriteLine("Peek  = " + q2.Peek());
            Console.WriteLine("Deques = " + q2.Dequeue());
            Console.WriteLine("Peek  = " + q2.Peek());
            Person p = new Person(2, "Anmol");
            Console.WriteLine("Contains Anmol = " + q2.Contains(p));
            Console.WriteLine(q2.Count());


            Console.WriteLine("------------------------------------------------ ");
            Console.WriteLine("Priority Queueu with Way 3 : - ");
            PriorityQueue3<int> q3 = new PriorityQueue3<int>();
            q3.Enqueue(1,2);
            q3.Enqueue(2, 3);
            q3.Enqueue(3, 5);
            q3.Enqueue(1, 2);
            q3.Enqueue(4, 2);
            q3.Enqueue(2, 2);
            q3.Enqueue(7, 10);
            Console.WriteLine("Count = " + q3.Count());
            Console.WriteLine("Peek  = " + q3.Peek());
            Console.WriteLine("Dequed element "  +q3.Dequeue());
            Console.WriteLine("Count = " + q3.Count());
            Console.WriteLine("Contains 2 = " + q3.Contains(3));


        }
    }
    public class Person : IPriority, IEquatable<Person>
    {
        public int Priority { get; set; }
        public string value { get; set; }
        public Person(int p, string v)
        {
            this.Priority = p;
            this.value = v;
        }

        public bool Equals(Person p)
        {
            if (p == null)
                return false;
            return this.value == p.value;
        }
        public override string ToString()
        {
            return this.value.ToString();
        }
        public override int GetHashCode()
        {
            if (this.Priority == null)
            {
                return 0;
            }
            else
            {
                return this.Priority.GetHashCode();
            }
        }


    }


}

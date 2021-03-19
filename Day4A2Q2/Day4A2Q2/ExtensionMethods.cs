using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A2Q2
{
    public static class ExtensionMethods
    {
        // CustomAll with Custom logic
        public static bool CustomAll<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            bool res = true;
            foreach (TSource s in source)
            {
                res= res && predicate.Invoke((TSource)s);
                if (!res)
                {
                    return res;
                }
            }
            return res;

        }
        // Custom Any working as Linq Any
        public static bool CustomAny<TSource>(this IEnumerable<TSource> source)
        {
            if (source.Count() != 0)
                return true;
            return false;
        }
        // Custom Any with Custom logic
        public static bool CustomAny<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {

            foreach (TSource s in source) {
                if (predicate.Invoke(s))
                    return true;
            }
            return false;
        }

        // Custom max working as Max of Linq
        public static int CustomMax(this IEnumerable<int> source)
        {
            int max = int.MinValue;
            foreach (int temp in source)
            {
                if (max < temp)
                    max = temp;
            }
            return max;
        }

        // Custom Max with custom logic
        public static int CustomMax(this IEnumerable<int> source, Func<int, bool> predicate)
        {
            foreach (int s in source)
            {
                var res = predicate.Invoke(s);
                if (res) return s;
            }
            if (source.Count() == 0)
                throw new System.InvalidOperationException("Source contain no elements");
            throw new Exception();
        }

        // Custom Min workin same as Linq Min
        public static int CustomMin(this IEnumerable<int> source)
        {
            int min = Int32.MaxValue;
            foreach(int num in source)
            {
                if (min > num)
                    min = num;
            }
            if(source.Count() == 0)
                Console.WriteLine("Invalid operation");
            return min;
        }

        // Custom Min with custom logic
        public static int CustomMin(this IEnumerable<int> source, Func<int, bool> predicate)
        {
            foreach (int s in source)
            {
                var res = predicate.Invoke(s);
                if (res) return s;
            }
            if (source.Count() == 0)
                throw new System.InvalidOperationException("Source contain no elements");
            throw new Exception();
        }
    }
}

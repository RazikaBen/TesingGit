using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace howToCOde
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*  foreach(var a in UniqueInOrder("AAAABBBCCDAABBB"))
               {
                 Console.WriteLine(a);
               }*/
           ;
         Console.WriteLine( FindMissing(new List<int> { 1040, 1220, 1580 }));
        //find(new List<int> { 1, 3, 5, 9, 11 });
        }

        public static string ExpandedForm(long num)
        {       if (num == 0) return 0.ToString();
            List<long> r = new List<long>();
            List<string> s = new List<string>();
            var n = 10;
            while (n <= num*10)
            {
             while(num % n == 0)
            {
                n *= 10;
            }
            r.Add(num % n);
            s.Add((num % n).ToString());
            
            num -= num % n; 
            }
            s.Reverse();
            return string.Join("+", s.ToArray());
        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T previous = default(T);
            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;

                }
            
            }
        }

        public static string Order(string words)
        {
            return string.Join(' ', words.Split(' ').OrderBy(i => i.ToList().Find(c=>char.IsDigit(c))));
        }

        public static int FindMissing(List<int> list)
        {
            List<int> l = new List<int>();
            int a = list[1] - list[0];
            int s = list[0];
            l.Add(s);
            for (int i=0; i < list.Count(); i++)
            {
                s += a;
                l.Add(s);

            }

          

           return l.Except(list).First();
            
        }

        public static int find(List<int> list)
        {
            List<int> l = new List<int>();
            int a = list[1] - list[0];
            int s = list[0];
            l = Enumerable.Range(list[0], list.Count()).ToList();
            l.ForEach((i) => {i = s + a; s = i; });
            
            foreach (var item in l)
            {
 Console.WriteLine(item);
            }
           return l.Except(list).First(); 
        }
    }
    

}

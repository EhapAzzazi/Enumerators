using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Integars ints = new Integars(10,20,30,40,50,60,70,80,90);
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
    class Integars : IEnumerable
    {
        int[] Items;
        public Integars(params int[] _items)
        {
            Items = _items;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }
    }
}

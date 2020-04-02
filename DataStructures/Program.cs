using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList(new int[] { 1, 2, 3, 4});
            //LinkedList L = new LinkedList(1);

            //L.RemoveFromBeginning(4);
            //L.RemoveByIndex(1, 5);
            //Console.WriteLine(L.FindMax());
            //Console.Write(L.FindIndexMin());
            L.SortInDescending();
            //L.ReverseArray();
            
            ReturnArr(L.ReturnArray());
            //Console.WriteLine(L.Length);            

        }

        static void ReturnArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}

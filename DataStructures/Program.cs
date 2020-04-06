using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList L = new DoubleLinkedList(new int[] { 1, 2, 3, 4});
            //DoubleLinkedList L = new DoubleLinkedList();
            //LinkedList L = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine(L.Length);
            //L[1] = 4;
            //Console.WriteLine(L[1]);
            //L.AddAtTheEnd(new int[] { 4, 5, 6 });
            //L.AddToTheBeginning(new int[] {6, 7, 8 });
            //L.AddByIndex(4, new int[] { 6, 7, 8 });
            //L.RemoveFromEnd();
            //L.RemoveFromBeginning(5);
            //L.RemoveByIndex(4, 4);
            //Console.WriteLine(L.FindMax());
            //Console.Write(L.FindIndexMin());
            //L.SortInDescending();
            L.ReverseArray();
            //L.RemoveByValue(6);
            
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

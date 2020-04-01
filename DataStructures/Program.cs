using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList(new int[] { 8, 4, 5, 6 });
            //LinkedList L = new LinkedList();
            //L.AddAtTheEnd(2);
            //L.AddAtTheEnd(3);
            //L.AddAtTheEnd(4);
            //L.AddAtTheEnd(new int[] {4, 5, 6});
            //L.AddToTheBeginning(new int[] { 9, 8, 7 });
            //L.AddByIndex(9, new int[] { 1, 2, 3 });
            L.RemoveFromEnd();

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

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        private Node root;
        private int length;

        public LinkedList()  //конструктор без входных данных
        {
            root = null;
            length = 0;
        }

        public LinkedList(int a)  //конструктор с числом на вход
        {
            root = new Node(a);
            length = 1;
        }

        public LinkedList(int[] a) ///конструктор с массивом на вход
        {
            root = new Node(a[0]);
            Node tmp = root;
            for (int i = 1; i < a.Length; i++)
            {
                tmp.Next = new Node(a[i]);
                tmp = tmp.Next;
            }
            length = a.Length;
        }

        public int Length  //возвращаем длину
        {
            get { return length; }
        }

        public int[] ReturnArray()  //возвращаем массив
        {
            int[] array = new int[Length];
            if (Length != 0)
            {
                int i = 0;
                Node tmp = root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                }
                while (tmp != null);
            }
            return array;
        }

        public int ReturnByIndex(int a)  //возвращаем значение по индексу
        {
            Node tmp = root;
            for (int i = 0; i < a; i++)
            {
                tmp = tmp.Next;
            }
            return tmp.Value;
        }

        public void ChangeByIndex(int a, int b)  //меняем значение по индексу
        {
            Node tmp = root;
            for (int i = 0; i < a; i++)
            {
                tmp = tmp.Next;
            }

            tmp.Value = b;
        }

        public void AddAtTheEnd(int a)  //добавляем значение в конец
        {
            if (Length == 0)
            {
                root = new Node(a);
                length = 1;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(a);
                length++;
            }
        }

        public void AddAtTheEnd(int[] a)  //добавляем массив в конец
        {
            if (Length == 0)
            {
                root = new Node(a[0]);
                Node tmp = root;
                for (int i = 1; i < a.Length; i++)
                {
                    tmp.Next = new Node(a[i]);
                    tmp = tmp.Next;
                }
                length = a.Length;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    tmp.Next = new Node(a[i]);
                    tmp = tmp.Next;
                }
                length += a.Length;
            }
        }

        public void AddToTheBeginning(int a)  //добавляем значение в начало
        {
            Node tmp = new Node(a);
            tmp.Next = root;
            root = tmp;
            length++;
        }

        public void AddToTheBeginning(int[] a)  //добавляем массив в начало
        {
            Node tmp = new Node(a[0]);
            Node b = root;
            root = tmp;
            for (int i = 1; i < a.Length; i++)
            {
                tmp.Next = new Node(a[i]);
                tmp = tmp.Next;
            }
            tmp.Next = b;
            length += a.Length;
        }

        public void AddByIndex(int index, int a)  //добавляем значение по индексу
        {
            if (Length < index)
            {
                AddAtTheEnd(a);
            }
            else
            {
                if (index == 0)
                {
                    AddToTheBeginning(a);
                }
                else
                {
                    Node tmp = root;
                    Node b = new Node(a);
                    for (int i = 0; i < index - 1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    Node c = tmp.Next;
                    tmp.Next = b;
                    b.Next = c;
                    length++;
                }
            }
        }

        public void AddByIndex(int index, int[] a)  //добавляем массив по индексу
        {
            if (Length < index)
            {
                AddAtTheEnd(a);
            }
            else
            {
                if (index == 0)
                {
                    AddToTheBeginning(a);
                }
                else
                {
                    Node tmp = root;
                    Node b = new Node(a[0]);
                    for (int i = 0; i < index - 1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    Node c = tmp.Next;
                    tmp.Next = b;
                    for (int i = 1; i < a.Length; i++)
                    {
                        b.Next = new Node(a[i]);
                        b = b.Next;
                    }
                    b.Next = c;
                    length += a.Length;
                }
            }
        }

        public void RemoveFromEnd()  //удаляем значение из конца
        {
            if (Length != 0)
            {
                Node tmp = root;
                Node b = new Node(0);
                while (tmp.Next != null)
                {
                    b = tmp;
                    tmp = tmp.Next;
                }
                tmp = b;
                tmp.Next = null;
                length--;
            }
        }

        public void RemoveFromEnd(int a)  //удаляем несколько значений из конца
        {
            if (Length != 0)
            {
                Node tmp = root;
                Node b = new Node(0);
                for (int i = 0; i < Length - a; i++)
                    while (tmp.Next != null)
                    {
                        b = tmp;
                        tmp = tmp.Next;
                    }
                tmp = b;
                tmp.Next = null;
                length--;
            }
        }
    }
}

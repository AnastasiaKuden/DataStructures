using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class DoubleLinkedList
    {
        private L2Node root;
        private L2Node end;
        private int length;

        public DoubleLinkedList()  //конструктор без входных данных
        {
            root = null;
            end = null;
            length = 0;
        }

        public DoubleLinkedList(int a)  //конструктор с числом на вход
        {
            root = new L2Node(a);
            end = root;
            length = 1;
        }

        public DoubleLinkedList(int[] a)  //конструктор с массивом на вход
        {
            if (a.Length != 0)
            {
                root = new L2Node(a[0]);
                L2Node tmp = root;
                for (int i = 1; i < a.Length; i++)
                {
                    tmp.Next = new L2Node(a[i]);
                    tmp.Next.Previous = tmp;
                    tmp = tmp.Next;
                }
                end = tmp;
                length = a.Length;
            }
            else
            {
                root = null;
                end = null;
                length = 0;
            }
        }

        public int[] ReturnArray()  //возвращаем массив
        {
            int[] array = new int[length];
            if (length != 0)
            {
                int i = 0;
                L2Node tmp = root;
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

        public int Length  //возвращаем длину
        {
            get { return length; }
        }

        public int this[int a]   //возвращаем значение по индексу, меняем значение по индексу
        {
            get
            {
                L2Node tmp = root;
                for (int i = 0; i < a; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }
            set
            {
                L2Node tmp = root;
                for (int i = 0; i < a; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            }
        }

        public void AddAtTheEnd(int a)  //добавляем значение в конец
        {
            if (Length == 0)
            {
                root = new L2Node(a);
                end = root;
                length = 1;
            }
            else
            {
                end.Next = new L2Node(a);
                end.Next.Previous = end;
                end = end.Next;
                length++;
            }
        }

        public void AddAtTheEnd(int[] a)  //добавляем массив в конец
        {
            if (Length == 0)
            {
                if (a.Length != 0)
                {
                    root = new L2Node(a[0]);
                    L2Node tmp = root;
                    for (int i = 1; i < a.Length; i++)
                    {
                        tmp.Next = new L2Node(a[i]);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                    }
                    end = tmp;
                    length = a.Length;
                }
                else
                {
                    root = null;
                    end = null;
                    length = 0;
                }
            }
            else
            {      
                if (a.Length != 0)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        end.Next = new L2Node(a[i]);
                        end.Next.Previous = end;
                        end = end.Next;
                    }
                    length += a.Length;
                }                
            }
        }

        public void AddToTheBeginning(int a)  //добавляем значение в начало
        {
            if (Length == 0)
            {
                root = new L2Node(a);
                end = root;
                length = 1;
            }
            else
            {
                root.Previous = new L2Node(a);
                root.Previous.Next = root;
                root = root.Previous;
                length++;
            }
        }

        public void AddToTheBeginning(int[] a)  //добавляем массив в начало
        {
            if (length == 0)
            {
                if (a.Length != 0)
                {
                    root = new L2Node(a[0]);
                    L2Node tmp = root;
                    for (int i = 1; i < a.Length; i++)
                    {
                        tmp.Next = new L2Node(a[i]);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                    }
                    end = tmp;
                    length = a.Length;
                }
                else
                {
                    root = null;
                    end = null;
                    length = 0;
                }
            }
            else
            {
                if (a.Length != 0)
                {
                    L2Node tmp = new L2Node(a[0]);
                    L2Node b = tmp;
                    for (int i = 1; i < a.Length; i++)
                    {
                        tmp.Next = new L2Node(a[i]);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                    }
                    tmp.Next = root;
                    root.Previous = tmp;
                    root = b;
                    length += a.Length;
                }
            }           
        }

        public void AddByIndex(int index, int a)  //добавляем значение по индексу
        {
            if (Length ==  0 || index >= Length)
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
                    if (index <= Length / 2)
                    {
                        L2Node tmp = root;                        
                        for (int i = 1; i < index; i++)
                        {
                            tmp = tmp.Next;
                        }
                        L2Node b = tmp.Next;
                        tmp.Next = new L2Node (a);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                        tmp.Next = b;
                        b.Previous = tmp;                        
                        length++;
                    }
                    else
                    {
                        L2Node tmp = end;
                        for (int i = Length - 1; i > index; i--)
                        {
                            tmp = tmp.Previous;
                        }
                        L2Node b = tmp.Previous;
                        tmp.Previous = new L2Node(a);
                        tmp.Previous.Next = tmp;
                        tmp = tmp.Previous;
                        tmp.Previous = b;
                        b.Next = tmp;
                        length++;
                    }
                }
            }
        }

        public void AddByIndex(int index, int[] a)  //добавляем массив по индексу
        {
            if (Length == 0 || index >= Length)
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
                    if (index <= Length / 2)
                    {
                        L2Node tmp = root;
                        for (int i = 1; i < index; i++)
                        {
                            tmp = tmp.Next;
                        }
                        L2Node b = tmp.Next;
                        for (int i = 0; i < a.Length; i++)
                        {
                            tmp.Next = new L2Node(a[i]);
                            tmp.Next.Previous = tmp;
                            tmp = tmp.Next;                            
                        }
                        tmp.Next = b;
                        b.Previous = tmp;
                        length += a.Length;
                    }
                    else
                    {
                        L2Node tmp = end;
                        for (int i = Length - 1; i > index; i--)
                        {
                            tmp = tmp.Previous;
                        }
                        L2Node b = tmp.Previous;
                        for (int i = a.Length - 1; i >= 0; i--)
                        {
                            tmp.Previous = new L2Node(a[i]);
                            tmp.Previous.Next = tmp;
                            tmp = tmp.Previous;
                        }                        
                        tmp.Previous = b;
                        b.Next = tmp;
                        length += a.Length;
                    }
                }
            }
        }

        public void RemoveFromEnd()  //удаляем значение из конца
        {
            if (Length != 0)
            {
                end.Previous.Next = null;
                end = end.Previous;                
                length--;
            }
        }

        public void RemoveFromEnd(int a)  //удаляем несколько значений из конца
        {
            if (Length != 0)
            {
                if (a < Length)
                {
                    for (int i = 0; i < a; i++)
                    {
                        end.Previous.Next = null;
                        end = end.Previous;
                    }
                    length -= a;
                }
                else
                {
                    root = null;
                    end = null;
                    length = 0;
                }                
            }
        }

        public void RemoveFromBeginning()  //удаляем значение из начала
        {
            if (Length != 0)
            {
                root = root.Next;
                length--;
            }
        }

        public void RemoveFromBeginning(int a)  //удаляем несколько значений из начала
        {
            if (Length != 0)
            {
                if (Length <= a)
                {
                    root = null;
                    length = 0;
                }
                else
                {
                    L2Node tmp = root;
                    for (int i = 0; i < a - 1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    root = tmp.Next;
                    length -= a;
                }
            }
        }

        public void RemoveByIndex(int index)  //удаляем значение по индексу
        {
            if (Length != 0 && Length > index)
            {
                if (index == 0)
                {
                    RemoveFromBeginning();
                }
                else if (index == Length - 1)
                {
                    RemoveFromEnd();
                }
                else
                {
                    if (index <= Length / 2)
                    {
                        L2Node tmp = root;
                        for (int i = 1; i < index; i++)
                        {
                            tmp = tmp.Next;
                        }
                        tmp.Next = tmp.Next.Next;
                        tmp.Next.Previous = tmp;
                        length--;
                    }
                    else
                    {
                        L2Node tmp = end;
                        for (int i = Length - 1; i > index; i--)
                        {
                            tmp = tmp.Previous;
                        }
                        tmp.Previous = tmp.Previous.Previous;
                        tmp.Previous.Next = tmp;                        
                        length--;
                    }   
                }                
            }
        }

        public void RemoveByIndex(int index, int a)  //удаляем несколько значений по индексу
        {
            if (Length != 0 && Length > index)
            {
                if (index == 0)
                {
                    RemoveFromBeginning(a);
                }                
                else
                {
                    if (a <= Length / 2)
                    {
                        L2Node tmp = root;
                        for (int i = 1; i < index; i++)
                        {
                            tmp = tmp.Next;
                        }
                        if (Length > index + a)
                        {
                            L2Node b = tmp.Next;
                            for (int i = 1; i < a; i++)
                            {
                                b = b.Next;
                            }
                            tmp.Next = b.Next;
                            tmp.Next.Previous = tmp;                            
                            length -= a;
                        }
                        else
                        {
                            tmp.Next = null;
                            end = tmp;
                            length = index;
                        }
                    }
                    else
                    {                       
                        if (Length > index + a)
                        {
                            L2Node tmp = end;
                            for (int i = Length - 1; i > index + a; i--)
                            {
                                tmp = tmp.Previous;
                            }
                            L2Node b = tmp.Previous;
                            for (int i = 1; i < a; i++)
                            {
                                b = b.Previous;
                            }
                            tmp.Previous = b.Previous;
                            tmp.Previous.Next = tmp;                            
                            length -= a;
                        }
                        else
                        {
                            L2Node tmp = end;
                            for (int i = Length; i > index; i--)
                            {
                                tmp = tmp.Previous;
                            }
                            tmp.Next = null;
                            end = tmp;
                            length = index;
                        }
                    }
                }
            }
        }

        public int FindIndex(int a)  //находим и возвращаем индекс по значению
        {
            int index = 0;
            int index1 = 0;
            L2Node tmp = root;
            while (tmp.Next != null)
            {
                if (tmp.Value == a)
                {
                    index1 = index;
                    break;
                }
                else
                {
                    index++;
                    tmp = tmp.Next;
                }
            }
            return index1;
        }

        public void ReverseArray()  //делаем реверс списка/массива
        {
            //L2Node tmp = end;
            root.Value = end.Value;
            end = root;
            

            //for (int i = 1; i < Length / 2; i++)
            //{
                //root.Next.Value = end.Previous.Value;
                //end.Previous.Value = tmp.Next.Value;
                //root.Next = root.Next.Next;
               // end.Previous = end.Previous.Previous;
                //tmp.Next = tmp.Next.Next;
            //}
        }
    }    
}

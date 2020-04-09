using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class DoubleLinkedList : IDataStructures
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
                int c;
                if (a >= length || length == 0 || a < 0)
                {
                    c = 0;
                }
                else
                {
                    L2Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    c = tmp.Value;
                }
                return c;
            }
            set
            {
                if (a >= 0 && a < length && length != 0)
                {
                    L2Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Value = value;
                }                    
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
            if (index >= 0)
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
                            tmp.Next = new L2Node(a);
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
        }

        public void AddByIndex(int index, int[] a)  //добавляем массив по индексу
        {
            if (index >= 0)
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
        }

        public void RemoveFromEnd()  //удаляем значение из конца
        {
            if (Length != 0)
            {
                if (Length != 1)
                {
                    end.Previous.Next = null;
                    end = end.Previous;
                    length--;
                }
                else
                {
                    root = null;
                    end = null;
                    length--;
                }                
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
                    if (a != 0)
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
        }

        public void RemoveByIndex(int index)  //удаляем значение по индексу
        {
            if (Length != 0 && index >= 0 && Length > index)
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
            if (Length != 0 && Length > index && index >= 0 && a >= 0)
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
            if (length != 0)
            {
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
            }            
            return index1;
        }

        public void ReverseArray()  //делаем реверс списка/массива
        {
            if (length != 0)
            {
                int a = root.Value;
                root.Value = end.Value;
                end.Value = a;
                L2Node b = end;
                L2Node tmp = root;
                for (int i = 1; i < length / 2; i++)
                {
                    a = tmp.Next.Value;
                    tmp.Next.Value = b.Previous.Value;
                    b.Previous.Value = a;
                    tmp = tmp.Next;
                    b = b.Previous;
                }
            }            
        }

        public int FindMax()  //находим максимальное значение
        {
            int max = 0;
            L2Node tmp = root;
            while (tmp != null)
            {
                if (max < tmp.Value)
                {
                    max = tmp.Value;
                }
                tmp = tmp.Next;
            }
            return max;
        }

        public int FindMin()  //находим минимальное значения
        {
            int min = 0;
            if (root != null)
            {
                min = root.Value;
                L2Node tmp = root;
                while (tmp != null)
                {
                    if (min > tmp.Value)
                    {
                        min = tmp.Value;
                    }
                    tmp = tmp.Next;
                }
            }
            return min;
        }

        public int FindIndexMax()  //находим индекс максимального значения
        {
            int a = 0;
            if (root != null)
            {
                int index = 0;
                int max = 0;
                L2Node tmp = root;
                while (tmp != null)
                {
                    if (max < tmp.Value)
                    {
                        max = tmp.Value;
                        a = index;
                    }
                    tmp = tmp.Next;
                    index++;
                }
            }
            else
            {
                a = -1;
            }
            return a;
        }

        public int FindIndexMin()  //находим индекс минимального значения
        {
            int a = 0;
            if (root != null)
            {
                int index = 0;
                int min = root.Value;
                L2Node tmp = root;
                while (tmp != null)
                {
                    if (min > tmp.Value)
                    {
                        min = tmp.Value;
                        a = index;
                    }
                    tmp = tmp.Next;
                    index++;
                }
            }
            else
            {
                a = -1;
            }
            return a;
        }

        public void SortInAscending()  //делаем сортировку по возрастанию (пузырьком)
        {
            if (Length != 0)
            {
                L2Node tmp = root;
                int l = 0;
                while (tmp.Next != null)
                {
                    if (tmp.Value > tmp.Next.Value)
                    {
                        int a = tmp.Next.Value;
                        tmp.Next.Value = tmp.Value;
                        tmp.Value = a;
                        l = 1;
                    }
                    tmp = tmp.Next;
                }
                if (l != 0)
                {
                    SortInAscending();
                }
            }            
        }

        public void SortInDescending()  //делаем сортировку по убыванию (вставкой)
        {
            if (Length != 0)
            {
                L2Node tmp = root;
                while (tmp.Next != null)
                {
                    if (tmp.Value < tmp.Next.Value)
                    {
                        int a = tmp.Next.Value;
                        tmp.Next.Value = tmp.Value;
                        tmp.Value = a;
                        SortInDescending();
                    }
                    else
                    {
                        tmp = tmp.Next;
                    }
                }
            }            
        }

        public void RemoveByValue(int a)  //удаляем по значению
        {
            if (Length != 0)
            {
                while (root.Value == a && Length > 1)
                {
                    root = root.Next;                    
                    length--;
                }
                if (Length == 1)
                {
                    if (root.Value == a)
                    {
                        root = null;
                        end = null;
                        length = 0;
                    }
                    else
                    {
                        end.Previous = root;                        
                    }
                }
                else
                {
                    L2Node tmp = root;
                    int b = Length;
                    L2Node c;
                    for (int i = 1; i < b - 1; i++)
                    {
                        if (tmp.Next.Value == a)
                        {
                            c = tmp.Next.Next;
                            tmp.Next = c;                            
                            c.Previous = tmp;
                            length--;
                        }
                        else
                        {
                            tmp = tmp.Next;
                        }
                    }
                    if (tmp.Next.Value == a)
                    {
                        tmp.Next = null;
                        end = tmp;
                        length--;
                    }
                    else
                    {
                        tmp = tmp.Next;
                        end = tmp.Next;
                    }
                    
                }
            }
        }
    }    
}

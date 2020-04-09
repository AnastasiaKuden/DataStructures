using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class ArrayList : IDataStructures
    {
        private int[] array;
        private int length;


        public ArrayList(int[] array)  //конструктор с массивом на вход
        {
            if (array.Length != 0)
            {
                this.array = array;
                this.length = array.Length;
            }
            else
            {
                array = new int[0];
                length = 0;
            }
            
        }

        public ArrayList(int a)   //конструктор с числом на вход
        {
            array = new int[1] { a };
            length = array.Length;
        }

        public ArrayList()   //конструктор без входных значений
        {
            array = new int[0];
            length = 0;
        }

        public int[] ReturnArray()  //возвращаем массив
        {
            int[] newarray = new int[length];
            for (int i = 0; i < length; i++)
            {
                newarray[i] = array[i];
            }
            return newarray;
        }

        public int Length   //возвращаем длину
        {
            get { return length; }
        }

        public int this[int a]   //возвращаем значение по индексу, меняем значение по индексу
        {
            get 
            {
                int c;
                if (a < 0 || a >= length || length == 0)
                {
                    c = 0;
                }
                else
                {
                    c = array[a];
                }
                return c;
            }
            set 
            { 
                if (a >= 0 && a < length && length != 0)
                {
                    array[a] = value;
                }
            }
        }

        private void UpArraySize()  //увеличиваем массив
        {
            int newlength = Convert.ToInt32(array.Length * 1.3 + 1);
            int[] newarray = new int[newlength];
            for (int i = 0; i < array.Length; i++)
            {
                newarray[i] = array[i];
            }
            array = newarray;
        }

        public void AddAtTheEnd(int a)  //добавляем значение в конец
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }
            array[length] = a;
            length++;
        }

        public void AddAtTheEnd(int[] a)  //добавляем массив в конец
        {
            while (length + a.Length >= array.Length)
            {
                UpArraySize();
            }
            for (int i = 0; i < a.Length; i++)
            {
                array[length + i] = a[i];
            }
            length += a.Length;
        }

        public void AddToTheBeginning(int a)  //добавляем значение в начало
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }
            for (int i = length; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = a;
            length++;
        }

        public void AddToTheBeginning(int[] a)  //добавляем массив в начало
        {
            while (length + a.Length >= array.Length)
            {
                UpArraySize();
            }
            for (int i = length + a.Length - 1; i >= a.Length; i--)
            {
                array[i] = array[i - a.Length];
            }
            for (int i = 0; i < a.Length; i++)
            {
                array[i] = a[i];
            }
            length += a.Length;
        }

        public void AddByIndex(int a, int b)  //добавляем значение по индексу
        {
            if (a >= 0)
            {
                if (length >= array.Length)
                {
                    UpArraySize();
                }
                if (length == 0 || a >= length)
                {
                    AddAtTheEnd(b);
                }
                else
                {
                    if (a == 0)
                    {
                        AddToTheBeginning(b);
                    }
                    else
                    {
                        for (int i = length; i > a; i--)
                        {
                            array[i] = array[i - 1];
                        }
                        array[a] = b;
                        length++;
                    }
                }                
            }           
        }

        public void AddByIndex(int a, int[] b)  //добавляем массив по индексу
        {
            if (a >= 0)
            {
                if (a > length)
                {
                    a = length;
                }
                while (length + b.Length >= array.Length)
                {
                    UpArraySize();
                }
                for (int i = length + b.Length - 1; i >= a + b.Length; i--)
                {
                    array[i] = array[i - b.Length];
                }
                for (int i = a; i < a + b.Length; i++)
                {
                    array[i] = b[i - a];
                }
                length += b.Length;
            }            
        }

        public void RemoveFromEnd()  //удаляем значение из конца
        {
            if (length != 0)
            {
                int[] newarray = new int[length - 1];
                for (int i = 0; i < length - 1; i++)
                {
                    newarray[i] = array[i];
                }
                array = newarray;
                length--;
            }            
        }

        public void RemoveFromEnd(int a)  //удаляем несколько значений из конца
        {
            if (Length != 0)
            {
                if (a < Length)
                {
                    int[] newarray = new int[length - a];
                    for (int i = 0; i < length - a; i++)
                    {
                        newarray[i] = array[i];
                    }
                    array = newarray;
                    length -= a;
                }
                else
                {
                    array = new int[0];
                    length = 0;
                }
            }            
        }

        public void RemoveFromBeginning()  //удаляем значение из начала
        {
            if (length != 0)
            {
                int[] newarray = new int[length - 1];
                for (int i = 0; i < length - 1; i++)
                {
                    newarray[i] = array[i + 1];
                }
                array = newarray;
                length--;
            }            
        }

        public void RemoveFromBeginning(int a)  //удаляем несколько значений из начала
        {
            if (length != 0)
            {
                if (a <= length)
                {
                    int[] newarray = new int[length - a];
                    for (int i = 0; i < length - a; i++)
                    {
                        newarray[i] = array[i + a];
                    }
                    array = newarray;
                    length -= a;
                }
                else
                {
                    array = new int[0];
                    length = 0;
                }
            }            
        }

        public void RemoveByIndex(int a)  //удаляем значение по индексу
        {
            if (length != 0 && a >= 0 && a < length)
            {
                int[] newarray = new int[length - 1];
                for (int i = 0; i < length - 1; i++)
                {
                    if (i < a)
                    {
                        newarray[i] = array[i];
                    }
                    else
                    {
                        newarray[i] = array[i + 1];
                    }
                }
                array = newarray;
                length--;
            }            
        }

        public void RemoveByIndex(int a, int b)  //удаляем несколько значений по индексу
        {
            if (length != 0 && a >= 0 && a < length && b >= 0)
            {
                if (a == 0)
                {
                    RemoveFromBeginning(b);
                }
                else
                {
                    if (Length > a + b)
                    {
                        int[] newarray = new int[length - b];
                        for (int i = 0; i < length - b; i++)
                        {
                            if (i < a)
                            {
                                newarray[i] = array[i];
                            }
                            else
                            {
                                newarray[i] = array[i + b];
                            }
                        }                        
                        array = newarray;
                        length -= b;
                    }
                    else
                    {
                        int[] newarray = new int[a];
                        for (int i = 0; i < a; i++)
                        {
                            newarray[i] = array[i];                            
                        }
                        array = newarray;
                        length = a;
                    }
                }                
            }            
        }

        public int FindIndex(int a)  //находим и возвращаем индекс по значению
        {
            int index = 0;
            for (int i = 0; i < length; i++)
            {
                if (array[i] == a)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void ReverseArray()  //делаем реверс массива
        {
            for (int i = 0; i < length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = tmp;
            }
        }

        public int FindMax()  //находим максимальное значение
        {
            int max;
            if (length != 0)
            {
                max = array[0];
                for (int i = 1; i < length; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                    }
                }                
            }
            else
            {
                max = 0;
            }
            return max;
        }

        public int FindMin()  //находим минимальное значения
        {
            int min;
            if (length != 0)
            {
                min = array[0];
                for (int i = 1; i < length; i++)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                    }
                }
            }
            else
            {
                min = 0;
            }            
            return min;
        }

        public int FindIndexMax()  //находим индекс максимального значения
        {
            int index = 0;
            if(length != 0)
            {
                int max = array[0];
                for (int i = 0; i < length; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                        index = i;
                    }
                }
            }
            else
            {
                index = -1;
            }
            return index;
        }

        public int FindIndexMin()  //находим индекс минимального значения
        {
            int index = 0;
            if (length != 0)
            {
                int min = array[0];
                for (int i = 1; i < length; i++)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                        index = i;
                    }
                }
            }
            else
            {
                index = -1;
            }
            return index;
        }

        public void SortInAscending() //делаем сортировку по возрастанию (пузырьком)
        {
            for (int i = 1; i < length; i++)
            {
                int l = 0;
                for (int j = 0; j < length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        l = 1;
                    }
                }
                if (l == 0)
                {
                    break;
                }
            }
        }

        public void SortInDescending()  //делаем сортировку по убыванию (вставкой)
        {
            for (int i = 1; i < length; i++)
            {
                int max = array[i];
                int j = i;
                while (j > 0 && array[j - 1] < max)
                {
                    array[j] = array[j - 1];
                    j -= 1;
                }
                array[j] = max;
            }
        }

        public void RemoveByValue(int a)  //удаляем по значению
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i] == a)
                {
                    RemoveByIndex(i);
                    i--;
                }
            }
        }
    }
}

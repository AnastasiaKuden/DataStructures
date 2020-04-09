using NUnit.Framework;
using DataStructures;

namespace DataStructures.tests
{
    [TestFixture(1)]
    [TestFixture(2)]
    [TestFixture(3)]

    public class Tests
    {
        IDataStructures actual;
        int q;

        public Tests(int q1)
        {
            q = q1;
        }

        [SetUp]
        public void DataStructureSelect()
        {
            switch (q)
            {
                case 1:
                    actual = new ArrayList();
                    break;
                case 2:
                    actual = new LinkedList();
                    break;
                case 3:
                    actual = new DoubleLinkedList();
                    break;
            }
        }

        //тест для возврата массива, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0, 5 }, ExpectedResult = new int[] { 1, 2, 3, 0, 5 })]
        [TestCase(new int[] { 0, -2, 5, 3, -4 }, ExpectedResult = new int[] { 0, -2, 5, 3, -4 })]
        [TestCase(new int[] { 8 }, ExpectedResult = new int[] { 8 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] TestReturnArray(int[] a)
        {
            AddMass(a);
            return actual.ReturnArray();
        }

        //тест для возврата массива, на вход число
        [TestCase(1, ExpectedResult = new int[] { 1 })]
        public int[] TestReturnArray(int a)
        {
            AddNumber(a);
            return actual.ReturnArray();
        }

        //тест для возврата массива без входных значений
        [TestCase(ExpectedResult = new int[] { })]
        public int[] TestReturnArray()
        {
            return actual.ReturnArray();
        }

        //тест для возврата длины, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 4)]
        [TestCase(new int[] { 0, -2, 5, 3, 4 }, ExpectedResult = 5)]
        [TestCase(new int[] { 8 }, ExpectedResult = 1)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int TestReturnLength(int[] a)
        {
            AddMass(a);
            return actual.Length;
        }

        //тест для возврата длины, на вход число
        [TestCase(1, ExpectedResult = 1)]
        public int TestReturnLength(int a)
        {
            AddNumber(a);
            return actual.Length;
        }

        //тест для возврата длины без входных значений
        [TestCase(ExpectedResult = 0)]
        public int TestReturnLength()
        {
            return actual.Length;
        }

        //тест для добавления значения в конец, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 7, ExpectedResult = new int[] { 1, 2, 3, 0, 7 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, -5, ExpectedResult = new int[] { 0, 2, 5, 3, 4, -5 })]
        [TestCase(new int[] { 8 }, 13, ExpectedResult = new int[] { 8, 13 })]
        [TestCase(new int[] { }, 10, ExpectedResult = new int[] { 10 })]
        public int[] TestAddAtTheEnd(int[] a, int b)
        {
            AddMass(a);
            actual.AddAtTheEnd(b);
            return actual.ReturnArray();
        }

        //тест для добавления значения в конец, на вход число
        [TestCase(0, 7, ExpectedResult = new int[] { 0, 7 })]
        public int[] TestAddAtTheEnd(int a, int b)
        {
            AddNumber(a);
            actual.AddAtTheEnd(b);
            return actual.ReturnArray();
        }

        //тест для добавления значения в конец без входных значений
        [TestCase(7, ExpectedResult = new int[] { 7 })]
        public int[] TestAddAtTheEnd(int b)
        {
            actual.AddAtTheEnd(b);
            return actual.ReturnArray();
        }

        //тест для добавления массива в конец, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, new int[] { 7, 9, 0 }, ExpectedResult = new int[] { 1, 2, 3, 0, 7, 9, 0 })]
        [TestCase(new int[] { 0, -2, 5, 3, -4 }, new int[] { }, ExpectedResult = new int[] { 0, -2, 5, 3, -4 })]
        [TestCase(new int[] { 8 }, new int[] { 13 }, ExpectedResult = new int[] { 8, 13 })]
        [TestCase(new int[] { }, new int[] { 13, 15 }, ExpectedResult = new int[] { 13, 15 })]
        [TestCase(new int[] { }, new int[] { }, ExpectedResult = new int[] { })]
        public int[] TestAddAtTheEnd(int[] a, int[] b)
        {
            AddMass(a);
            actual.AddAtTheEnd(b);
            return actual.ReturnArray();
        }

        //тест для добавления массива в конец, на вход число
        [TestCase(-1, new int[] { 7, 9, 0 }, ExpectedResult = new int[] { -1, 7, 9, 0 })]
        [TestCase(2, new int[] { }, ExpectedResult = new int[] { 2 })]
        [TestCase(3, new int[] { -13 }, ExpectedResult = new int[] { 3, -13 })]
        public int[] TestAddAtTheEnd(int a, int[] b)
        {
            AddNumber(a);
            actual.AddAtTheEnd(b);
            return actual.ReturnArray();
        }

        //тест для добавления массива в конец без входных значений
        [TestCase(new int[] { 7, 9, 0 }, ExpectedResult = new int[] { 7, 9, 0 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { -13 }, ExpectedResult = new int[] { -13 })]
        public int[] TestAddAtTheEnd(int[] b)
        {
            actual.AddAtTheEnd(b);
            return actual.ReturnArray();
        }

        //тест для добавления значения в начало, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 7, ExpectedResult = new int[] { 7, 1, 2, 3, 0 })]
        [TestCase(new int[] { 0, -2, 5, 3, 4 }, -5, ExpectedResult = new int[] { -5, 0, -2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 13, ExpectedResult = new int[] { 13, 8 })]
        [TestCase(new int[] { }, 10, ExpectedResult = new int[] { 10 })]
        public int[] TestAddToTheBeginning(int[] a, int b)
        {
            AddMass(a);
            actual.AddToTheBeginning(b);
            return actual.ReturnArray();
        }

        //тест для добавления значения в начало, на вход число
        [TestCase(1, 7, ExpectedResult = new int[] { 7, 1 })]
        public int[] TestAddToTheBeginning(int a, int b)
        {
            AddNumber(a);
            actual.AddToTheBeginning(b);
            return actual.ReturnArray();
        }

        //тест для добавления значения в начало без входных значений
        [TestCase(7, ExpectedResult = new int[] { 7 })]
        public int[] TestAddToTheBeginning(int b)
        {
            actual.AddToTheBeginning(b);
            return actual.ReturnArray();
        }

        //тест для добавления массива в начало, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, new int[] { 7, 9, 0 }, ExpectedResult = new int[] { 7, 9, 0, 1, 2, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, new int[] { }, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, new int[] { 13 }, ExpectedResult = new int[] { 13, 8 })]
        [TestCase(new int[] { }, new int[] { 10 }, ExpectedResult = new int[] { 10 })]
        public int[] TestAddToTheBeginning(int[] a, int[] b)
        {
            AddMass(a);
            actual.AddToTheBeginning(b);
            return actual.ReturnArray();
        }

        //тест для добавления массива в начало, на вход число
        [TestCase(1, new int[] { 7, 9, 0 }, ExpectedResult = new int[] { 7, 9, 0, 1 })]
        [TestCase(2, new int[] { }, ExpectedResult = new int[] { 2 })]
        public int[] TestAddToTheBeginning(int a, int[] b)
        {
            AddNumber(a);
            actual.AddToTheBeginning(b);
            return actual.ReturnArray();
        }

        //тест для добавления массива в начало без входных значений
        [TestCase(new int[] { 7, 9, 0 }, ExpectedResult = new int[] { 7, 9, 0 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] TestAddToTheBeginning(int[] b)
        {
            actual.AddToTheBeginning(b);
            return actual.ReturnArray();
        }


        //тест для добавления значения по индексу, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 2, 7, ExpectedResult = new int[] { 1, 2, 7, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 0, -5, ExpectedResult = new int[] { -5, 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 4, -5, ExpectedResult = new int[] { 0, 2, 5, 3, -5, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 5, -5, ExpectedResult = new int[] { 0, 2, 5, 3, 4, -5 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 10, -5, ExpectedResult = new int[] { 0, 2, 5, 3, 4, -5 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, -2, -5, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 0, 13, ExpectedResult = new int[] { 13, 8 })]
        [TestCase(new int[] { }, 5, 12, ExpectedResult = new int[] { 12 })]
        public int[] TestAddByIndex(int[] a, int b, int c)
        {
            AddMass(a);
            actual.AddByIndex(b, c);
            return actual.ReturnArray();
        }

        //тест для добавления значения по индексу, на вход число
        [TestCase(1, 0, 7, ExpectedResult = new int[] { 7, 1 })]
        [TestCase(2, 1, -5, ExpectedResult = new int[] { 2, -5 })]
        [TestCase(3, -8, -5, ExpectedResult = new int[] { 3 })]
        [TestCase(4, 5, -5, ExpectedResult = new int[] { 4, -5 })]
        public int[] TestAddByIndex(int a, int b, int c)
        {
            AddNumber(a);
            actual.AddByIndex(b, c);
            return actual.ReturnArray();
        }

        //тест для добавления значения по индексу без входных значений
        [TestCase(0, 7, ExpectedResult = new int[] { 7 })]
        [TestCase(2, -5, ExpectedResult = new int[] { -5 })]
        [TestCase(-8, 5, ExpectedResult = new int[] { })]
        public int[] TestAddByIndex(int b, int c)
        {
            actual.AddByIndex(b, c);
            return actual.ReturnArray();
        }

        //тест для добавления массива по индексу, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 2, new int[] { 7, 0, 5 }, ExpectedResult = new int[] { 1, 2, 7, 0, 5, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 0, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { -5, 5, 4, 18, 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 4, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { 0, 2, 5, 3, -5, 5, 4, 18, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 5, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { 0, 2, 5, 3, 4, -5, 5, 4, 18 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 10, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { 0, 2, 5, 3, 4, -5, 5, 4, 18 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, -5, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 1, new int[] { 13 }, ExpectedResult = new int[] { 8, 13 })]
        [TestCase(new int[] { }, 0, new int[] { }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { }, 5, new int[] { }, ExpectedResult = new int[] { })]
        public int[] TestAddByIndex(int[] a, int b, int[] c)
        {
            AddMass(a);
            actual.AddByIndex(b, c);
            return actual.ReturnArray();
        }

        //тест для добавления массива по индексу, на вход число
        [TestCase(1, 0, new int[] { 7, 0, 5 }, ExpectedResult = new int[] { 7, 0, 5, 1 })]
        [TestCase(1, 1, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { 1, -5, 5, 4, 18 })]
        [TestCase(1, 4, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { 1, -5, 5, 4, 18 })]
        [TestCase(1, -5, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { 1 })]
        public int[] TestAddByIndex(int a, int b, int[] c)
        {
            AddNumber(a);
            actual.AddByIndex(b, c);
            return actual.ReturnArray();
        }

        //тест для добавления массива по индексу без входных значений
        [TestCase(0, new int[] { 7, 0, 5 }, ExpectedResult = new int[] { 7, 0, 5 })]
        [TestCase(1, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { -5, 5, 4, 18 })]
        [TestCase(-4, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { })]
        public int[] TestAddByIndex(int b, int[] c)
        {
            actual.AddByIndex(b, c);
            return actual.ReturnArray();
        }

        //тест для удаления значения из конца, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromEnd(int[] a)
        {
            AddMass(a);
            actual.RemoveFromEnd();
            return actual.ReturnArray();
        }

        //тест для удаления значения из конца, на вход число
        [TestCase(1, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromEnd(int a)
        {
            AddNumber(a);
            actual.RemoveFromEnd();
            return actual.ReturnArray();
        }

        //тест для удаления значения из конца без входных значений
        [TestCase(ExpectedResult = new int[] { })]
        public int[] TestRemoveFromEnd()
        {
            actual.RemoveFromEnd();
            return actual.ReturnArray();
        }

        //тест для удаления нескольких значений из конца, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 3, ExpectedResult = new int[] { 1 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 0, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 5, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 6, ExpectedResult = new int[] { })]
        [TestCase(new int[] { }, 0, ExpectedResult = new int[] { })]
        [TestCase(new int[] { }, 5, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromEnd(int[] a, int b)
        {
            AddMass(a);
            actual.RemoveFromEnd(b);
            return actual.ReturnArray();
        }

        //тест для удаления нескольких значений из конца, на вход число
        [TestCase(1, 1, ExpectedResult = new int[] { })]
        [TestCase(1, 0, ExpectedResult = new int[] { 1 })]
        [TestCase(1, 2, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromEnd(int a, int b)
        {
            AddNumber(a);
            actual.RemoveFromEnd(b);
            return actual.ReturnArray();
        }

        //тест для удаления нескольких значений из конца без входных значений
        [TestCase(1, ExpectedResult = new int[] { })]
        [TestCase(0, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromEndUsingEmpty(int b)
        {
            actual.RemoveFromEnd(b);
            return actual.ReturnArray();
        }

        //тест для удаления значения из начала, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 2, 3, 0 })]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromBeginning(int[] a)
        {
            AddMass(a);
            actual.RemoveFromBeginning();
            return actual.ReturnArray();
        }

        //тест для удаления значения из начала, на вход число
        [TestCase(1, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromBeginning(int a)
        {
            AddNumber(a);
            actual.RemoveFromBeginning();
            return actual.ReturnArray();
        }

        //тест для удаления значения из начала без входных значений
        [TestCase(ExpectedResult = new int[] { })]
        public int[] TestRemoveFromBeginning()
        {
            actual.RemoveFromBeginning();
            return actual.ReturnArray();
        }

        //тест для удаления нескольких значений из начала, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 2, ExpectedResult = new int[] { 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 0, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 4, ExpectedResult = new int[] { 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 8, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 8 }, 1, ExpectedResult = new int[] { })]
        [TestCase(new int[] { }, 1, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromBeginning(int[] a, int b)
        {
            AddMass(a);
            actual.RemoveFromBeginning(b);
            return actual.ReturnArray();
        }

        //тест для удаления нескольких значений из начала, на вход число
        [TestCase(1, 2, ExpectedResult = new int[] { })]
        [TestCase(1, 0, ExpectedResult = new int[] { 1 })]
        [TestCase(1, 1, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromBeginning(int a, int b)
        {
            AddNumber(a);
            actual.RemoveFromBeginning(b);
            return actual.ReturnArray();
        }

        //тест для удаления нескольких значений из начала без входных значений
        [TestCase(2, ExpectedResult = new int[] { })]
        [TestCase(0, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromBeginningUsingEmpty(int b)
        {
            actual.RemoveFromBeginning(b);
            return actual.ReturnArray();
        }

        //тест для удаления значения по индексу, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 1, ExpectedResult = new int[] { 1, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 0, ExpectedResult = new int[] { 2, 5, 3, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 4, ExpectedResult = new int[] { 0, 2, 5, 3 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, -1, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 20, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 0, ExpectedResult = new int[] { })]
        [TestCase(new int[] { }, 0, ExpectedResult = new int[] { })]
        [TestCase(new int[] { }, 9, ExpectedResult = new int[] { })]
        public int[] TestRemoveByIndex(int[] a, int b)
        {
            AddMass(a);
            actual.RemoveByIndex(b);
            return actual.ReturnArray();
        }

        //тест для удаления значения по индексу, на вход число
        [TestCase(1, 0, ExpectedResult = new int[] { })]
        [TestCase(1, -3, ExpectedResult = new int[] { 1})]
        [TestCase(1, 4, ExpectedResult = new int[] { 1})]        
        public int[] TestRemoveByIndex(int a, int b)
        {
            AddNumber(a);
            actual.RemoveByIndex(b);
            return actual.ReturnArray();
        }

        //тест для удаления значения по индексу без входных значений
        [TestCase(0, ExpectedResult = new int[] { })]
        [TestCase(-3, ExpectedResult = new int[] { })]
        [TestCase(4, ExpectedResult = new int[] { })]
        public int[] TestRemoveByIndex(int b)
        {
            actual.RemoveByIndex(b);
            return actual.ReturnArray();
        }

        //тест для удаления несколький значения по индексу, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0, 7 }, 1, 1, ExpectedResult = new int[] { 1, 3, 0, 7 })]
        [TestCase(new int[] { 1, 2, 3, 0, 7 }, 0, 3, ExpectedResult = new int[] { 0, 7 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 0, 5, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 4, 1, ExpectedResult = new int[] { 0, 2, 5, 3})]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 2, 15, ExpectedResult = new int[] { 0, 2})]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 6, 2, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, -1, 3, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 2, -3, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 0, 0, ExpectedResult = new int[] { 8 })]
        [TestCase(new int[] { 8 }, 7, 0, ExpectedResult = new int[] { 8 })]
        [TestCase(new int[] { }, 0, 1, ExpectedResult = new int[] { })]
        public int[] TestRemoveByIndex(int[] a, int b, int c)
        {
            AddMass(a);
            actual.RemoveByIndex(b, c);
            return actual.ReturnArray();
        }

        //тест для удаления несколький значения по индексу, на вход число
        [TestCase(1, 0, 0, ExpectedResult = new int[] { 1})]
        [TestCase(1, 0, 1, ExpectedResult = new int[] { })]
        [TestCase(1, 0, 5, ExpectedResult = new int[] { })]
        [TestCase(1, 4, 1, ExpectedResult = new int[] { 1 })]
        [TestCase(1, -2, 1, ExpectedResult = new int[] { 1})]
        [TestCase(1, 0, -1, ExpectedResult = new int[] { 1 })]
        public int[] TestRemoveByIndex(int a, int b, int c)
        {
            AddNumber(a);
            actual.RemoveByIndex(b, c);
            return actual.ReturnArray();
        }

        //тест для удаления несколький значения по индексу без входных значений
        [TestCase(0, 0, ExpectedResult = new int[] { })]
        [TestCase(0, 1, ExpectedResult = new int[] { })]
        [TestCase(2, -5, ExpectedResult = new int[] { })]
        [TestCase(-1, 0, ExpectedResult = new int[] { })]        
        public int[] TestRemoveByIndexUsingEmpty(int b, int c)
        {
            actual.RemoveByIndex(b, c);
            return actual.ReturnArray();
        }

        //тест для возврата элемента по индексу, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 1, ExpectedResult = 2)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 0, ExpectedResult = 0)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 4, ExpectedResult = 4)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 5, ExpectedResult = 0)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, -5, ExpectedResult = 0)]
        [TestCase(new int[] { 8 }, 0, ExpectedResult = 8)]
        [TestCase(new int[] { }, 0, ExpectedResult = 0)]
        public int TestFindByIndex(int[] a, int b)
        {
            AddMass(a);
            return actual[b];
        }

        //тест для возврата элемента по индексу, на вход число
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(1, -6, ExpectedResult = 0)]
        [TestCase(1, 4, ExpectedResult = 0)]        
        public int TestFindByIndex(int a, int b)
        {
            AddNumber(a);
            return actual[b];
        }

        //тест для возврата элемента по индексу без входных значений
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(-1, ExpectedResult = 0)]
        public int TestFindByIndex(int b)
        {
            return actual[b];
        }

        //тест для возврата индекса по значению, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 3, ExpectedResult = 2)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 9, ExpectedResult = 0)]
        [TestCase(new int[] { }, 1, ExpectedResult = 0)]
        public int TestFindIndex(int[] a, int b)
        {
            AddMass(a);
            return actual.FindIndex(b);
        }

        //тест для возврата индекса по значению, на вход число
        [TestCase(1, 1, ExpectedResult = 0)]
        [TestCase(4, 0, ExpectedResult = 0)]
        public int TestFindIndex(int a, int b)
        {
            AddNumber(a);
            return actual.FindIndex(b);
        }

        //тест для возврата индекса по значению без входных значений
        [TestCase(3, ExpectedResult = 0)]        
        public int TestFindIndex(int b)
        {
            return actual.FindIndex(b);
        }

        //тест для изменения значения по индексу, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 2, 5, ExpectedResult = new int[] { 1, 2, 5, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 5, -8, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, -5, 4, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 0, 15, ExpectedResult = new int[] { 15 })]
        [TestCase(new int[] { }, 0, 1, ExpectedResult = new int[] { })]
        public int[] TestChangesByIndex(int[] a, int b, int c)
        {
            AddMass(a);
            actual[b] = c;
            return actual.ReturnArray();
        }

        //тест для изменения значения по индексу, на вход число
        [TestCase(1, 0, 5, ExpectedResult = new int[] { 5 })]
        [TestCase(1, 5, -8, ExpectedResult = new int[] { 1})]
        [TestCase(1, -5, 4, ExpectedResult = new int[] {1})]        
        public int[] TestChangesByIndex(int a, int b, int c)
        {
            AddNumber(a);
            actual[b] = c;
            return actual.ReturnArray();
        }

        //тест для изменения значения по индексу без входных значений
        [TestCase(0, 5, ExpectedResult = new int[] {  })]        
        public int[] TestChangesByIndex(int b, int c)
        {
            actual[b] = c;
            return actual.ReturnArray();
        }

        //тест для реверса массива, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 0, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 0, 5 }, ExpectedResult = new int[] {5, 0, 3, 2, 1 })]
        [TestCase(new int[] { 3}, ExpectedResult = new int[] { 3})]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] TestReverseArray(int[] a)
        {
            AddMass(a);
            actual.ReverseArray();
            return actual.ReturnArray();
        }

        //тест для реверса массива, на вход число
        [TestCase(1, ExpectedResult = new int[] { 1})]        
        public int[] TestReverseArray(int a)
        {
            AddNumber(a);
            actual.ReverseArray();
            return actual.ReturnArray();
        }

        //тест для реверса массива без входных значений
        [TestCase(ExpectedResult = new int[] { })]
        public int[] TestReverseArray()
        {
            actual.ReverseArray();
            return actual.ReturnArray();
        }

        //тест для нахождения максимального значения, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 3)]
        [TestCase(new int[] { 0, 0, 0, 0}, ExpectedResult = 0)]
        [TestCase(new int[] { 10, 2, 3, 0 }, ExpectedResult = 10)]
        [TestCase(new int[] { 1, 2, 3, 20 }, ExpectedResult = 20)]
        [TestCase(new int[] { 8 }, ExpectedResult = 8)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int TestFindMax(int[] a)
        {
            AddMass(a);
            return actual.FindMax();
        }

        //тест для нахождения максимального значения, на вход число
        [TestCase(5, ExpectedResult = 5)]        
        public int TestFindMax(int a)
        {
            AddNumber(a);
            return actual.FindMax();
        }

        //тест для нахождения максимального значения без входных значений
        [TestCase(ExpectedResult = 0)]        
        public int TestFindMax()
        {
            return actual.FindMax();
        }


        //тест для нахождения минимального значения, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 0, 0, 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 0, 2, 3, 9 }, ExpectedResult = 0)]
        [TestCase(new int[] { 10, 2, 3, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 3 }, ExpectedResult = 3)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int TestFindMin(int[] a)
        {
            AddMass(a);
            return actual.FindMin();
        }

        //тест для нахождения минимального значения, на вход число
        [TestCase(5, ExpectedResult = 5)]
        public int TestFindMin(int a)
        {
            AddNumber(a);
            return actual.FindMin();
        }

        //тест для нахождения минимального значения без входных значений
        [TestCase(ExpectedResult = 0)]
        public int TestFindMin()
        {
            return actual.FindMin();
        }

        //тест для нахождения индекса максимального значения, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 2)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = 2)]
        [TestCase(new int[] { 8 }, ExpectedResult = 0)]
        [TestCase(new int[] { }, ExpectedResult = -1)]
        public int TestFindIndexMax(int[] a)
        {
            AddMass(a);
            return actual.FindIndexMax();
        }

        //тест для нахождения индекса максимального значения, на вход число
        [TestCase(1, ExpectedResult = 0)]        
        public int TestFindIndexMax(int a)
        {
            AddNumber(a);
            return actual.FindIndexMax();
        }

        //тест для нахождения индекса максимального значения без входных значений
        [TestCase(ExpectedResult = -1)]
        public int TestFindIndexMax()
        {
            return actual.FindIndexMax();
        }

        //тест для нахождения индекса минимального значения, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 3)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = 0)]
        [TestCase(new int[] { 8 }, ExpectedResult = 0)]
        [TestCase(new int[] { }, ExpectedResult = -1)]
        public int TestFindIndexMin(int[] a)
        {
            AddMass(a);
            return actual.FindIndexMin();
        }

        //тест для нахождения индекса минимального значения, на вход число
        [TestCase(1, ExpectedResult = 0)]        
        public int TestFindIndexMin(int a)
        {
            AddNumber(a);
            return actual.FindIndexMin();
        }

        //тест для нахождения индекса минимального значения без входных значений
        [TestCase(ExpectedResult = -1)]
        public int TestFindIndexMin()
        {
            return actual.FindIndexMin();
        }

        //тест для сортировки по возрастанию, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 0, 1, 2, 3 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = new int[] { 0, 2, 3, 4, 5 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, ExpectedResult = new int[] { 0, 1, 2, 3, 4 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 8 }, ExpectedResult = new int[] { 8 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] TestSortInAscending(int[] a)
        {
            AddMass(a);
            actual.SortInAscending();
            return actual.ReturnArray();
        }

        //тест для сортировки по возрастанию, на вход число
        [TestCase(1, ExpectedResult = new int[] { 1})]        
        public int[] TestSortInAscending(int a)
        {
            AddNumber(a);
            actual.SortInAscending();
            return actual.ReturnArray();
        }

        //тест для сортировки по возрастанию без входных значений
        [TestCase(ExpectedResult = new int[] { })]
        public int[] TestSortInAscending()
        {
            actual.SortInAscending();
            return actual.ReturnArray();
        }

        //тест для сортировки по убыванию, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 3, 2, 1, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = new int[] { 5, 4, 3, 2, 0 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, ExpectedResult = new int[] { 4, 3, 2, 1, 0 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, ExpectedResult = new int[] { 5, 4, 3, 2, 1})]
        [TestCase(new int[] { 8 }, ExpectedResult = new int[] { 8 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] TestSortInDescending(int[] a)
        {
            AddMass(a);
            actual.SortInDescending();
            return actual.ReturnArray();
        }

        //тест для сортировки по убыванию, на вход число
        [TestCase(1, ExpectedResult = new int[] { 1 })]        
        public int[] TestSortInDescending(int a)
        {
            AddNumber(a);
            actual.SortInDescending();
            return actual.ReturnArray();
        }

        //тест для сортировки по убыванию без входных значений
        [TestCase(ExpectedResult = new int[] { })]
        public int[] TestSortInDescending()
        {
            actual.SortInDescending();
            return actual.ReturnArray();
        }

        //тест для удаления по значению, на вход массив
        [TestCase(new int[] { 1, 2, 3, 0 }, 5, ExpectedResult = new int[] { 1, 2, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4, 0 }, 0, ExpectedResult = new int[] { 2, 5, 3, 4 })]
        [TestCase(new int[] { 3, 3, 4, 3, 5, 3, 3, 1}, 3, ExpectedResult = new int[] { 4, 5, 1})]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 1, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 8 }, 8, ExpectedResult = new int[] { })]
        [TestCase(new int[] {  }, 8, ExpectedResult = new int[] { })]
        public int[] TestRemoveByValue(int[] a, int b)
        {
            AddMass(a);
            actual.RemoveByValue(b);
            return actual.ReturnArray();
        }

        //тест для удаления по значению, на вход число
        [TestCase(1, 5, ExpectedResult = new int[] { 1 })]
        [TestCase(0, 0, ExpectedResult = new int[] { })]        
        public int[] TestRemoveByValue(int a, int b)
        {
            AddNumber(a);
            actual.RemoveByValue(b);
            return actual.ReturnArray();
        }

        //тест для удаления по значению без входных значений
        [TestCase(5, ExpectedResult = new int[] { })]        
        public int[] TestRemoveByValue(int b)
        {
            actual.RemoveByValue(b);
            return actual.ReturnArray();
        }



        public void AddMass(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                actual.AddAtTheEnd(array[i]);
            }
        }

        public void AddNumber(int b)
        {
            actual.AddAtTheEnd(b);
        }
       
    }
}
using NUnit.Framework;
using DataStructures;

namespace DataStructures.tests
{
    public class Tests
    {
        //���� ��� �������� �������
        [TestCase(new int[] { 1, 2, 3, 0, 5 }, ExpectedResult = new int[] { 1, 2, 3, 0, 5 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = new int[] { 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, ExpectedResult = new int[] { 8 })]
        public int[] TestReturnArray(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.ReturnArray();
        }

        //���� ��� �������� �����
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 4)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = 5)]
        [TestCase(new int[] { 8 }, ExpectedResult = 1)]
        public int TestReturnLength(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.Length;
        }

        //���� ��� ���������� �������� � �����
        [TestCase(new int[] { 1, 2, 3, 0 }, 7, ExpectedResult = new int[] { 1, 2, 3, 0, 7 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, -5, ExpectedResult = new int[] { 0, 2, 5, 3, 4, -5 })]
        [TestCase(new int[] { 8 }, 13, ExpectedResult = new int[] { 8, 13 })]
        public int[] TestAddAtTheEnd(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            actual.AddAtTheEnd(b);
            return actual.ReturnArray();
        }

        //���� ��� ���������� ������� � �����
        [TestCase(new int[] { 1, 2, 3, 0 }, new int[] { 7, 9, 0 }, ExpectedResult = new int[] { 1, 2, 3, 0, 7, 9, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, new int[] { -5, 2 }, ExpectedResult = new int[] { 0, 2, 5, 3, 4, -5, 2 })]
        [TestCase(new int[] { 8 }, new int[] { 13 }, ExpectedResult = new int[] { 8, 13 })]
        public int[] TestAddAtTheEnd(int[] a, int[] b)
        {
            ArrayList actual = new ArrayList(a);
            actual.AddAtTheEnd(b);
            return actual.ReturnArray();
        }

        //���� ��� ���������� �������� � ������
        [TestCase(new int[] { 1, 2, 3, 0 }, 7, ExpectedResult = new int[] { 7, 1, 2, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, -5, ExpectedResult = new int[] { -5, 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 13, ExpectedResult = new int[] { 13, 8 })]
        public int[] TestAddToTheBeginning(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            actual.AddToTheBeginning(b);
            return actual.ReturnArray();
        }

        //���� ��� ���������� ������� � ������
        [TestCase(new int[] { 1, 2, 3, 0 }, new int[] { 7, 9, 0 }, ExpectedResult = new int[] { 7, 9, 0, 1, 2, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, new int[] { -5, 2 }, ExpectedResult = new int[] { -5, 2, 0, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, new int[] { 13 }, ExpectedResult = new int[] { 13, 8 })]
        public int[] TestAddToTheBeginning(int[] a, int[] b)
        {
            ArrayList actual = new ArrayList(a);
            actual.AddToTheBeginning(b);
            return actual.ReturnArray();
        }

        //���� ��� ���������� �������� �� �������
        [TestCase(new int[] { 1, 2, 3, 0 }, 2, 7, ExpectedResult = new int[] { 1, 2, 7, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 1, -5, ExpectedResult = new int[] { 0, -5, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 0, 13, ExpectedResult = new int[] { 13, 8 })]
        public int[] TestAddByIndex(int[] a, int b, int c)
        {
            ArrayList actual = new ArrayList(a);
            actual.AddByIndex(b, c);
            return actual.ReturnArray();
        }

        //���� ��� ���������� ������� �� �������
        [TestCase(new int[] { 1, 2, 3, 0 }, 2, new int[] { 7, 0, 5 }, ExpectedResult = new int[] { 1, 2, 7, 0, 5, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 1, new int[] { -5, 5, 4, 18 }, ExpectedResult = new int[] { 0, -5, 5, 4, 18, 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 0, new int[] { 13 }, ExpectedResult = new int[] { 13, 8 })]
        public int[] TestAddByIndex(int[] a, int b, int[] c)
        {
            ArrayList actual = new ArrayList(a);
            actual.AddByIndex(b, c);
            return actual.ReturnArray();
        }

        //���� ��� �������� �������� �� �����
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = new int[] { 0, 2, 5, 3 })]
        [TestCase(new int[] { 8 }, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromEnd(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            actual.RemoveFromEnd();
            return actual.ReturnArray();
        }

        //���� ��� �������� ���������� �������� �� �����
        [TestCase(new int[] { 1, 2, 3, 0 }, 3, ExpectedResult = new int[] { 1 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 2, ExpectedResult = new int[] { 0, 2, 5 })]
        [TestCase(new int[] { 8 }, 1, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromEnd(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            actual.RemoveFromEnd(b);
            return actual.ReturnArray();
        }

        //���� ��� �������� �������� �� ������
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 2, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = new int[] { 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromBeginning(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            actual.RemoveFromBeginning();
            return actual.ReturnArray();
        }

        //���� ��� �������� ���������� �������� �� ������
        [TestCase(new int[] { 1, 2, 3, 0 }, 2, ExpectedResult = new int[] { 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 3, ExpectedResult = new int[] { 3, 4 })]
        [TestCase(new int[] { 8 }, 1, ExpectedResult = new int[] { })]
        public int[] TestRemoveFromBeginning(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            actual.RemoveFromBeginning(b);
            return actual.ReturnArray();
        }

        //���� ��� �������� �������� �� �������
        [TestCase(new int[] { 1, 2, 3, 0 }, 1, ExpectedResult = new int[] { 1, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 2, ExpectedResult = new int[] { 0, 2, 3, 4 })]
        [TestCase(new int[] { 8 }, 0, ExpectedResult = new int[] { })]
        public int[] TestRemoveByIndex(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            actual.RemoveByIndex(b);
            return actual.ReturnArray();
        }

        //���� ��� �������� ���������� �������� �� �������
        [TestCase(new int[] { 1, 2, 3, 0 }, 1, 1, ExpectedResult = new int[] { 1, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 2, 2, ExpectedResult = new int[] { 0, 2, 4 })]
        [TestCase(new int[] { 8 }, 0, 0, ExpectedResult = new int[] { 8 })]
        public int[] TestRemoveByIndex(int[] a, int b, int c)
        {
            ArrayList actual = new ArrayList(a);
            actual.RemoveByIndex(b, c);
            return actual.ReturnArray();
        }

        //���� ��� �������� �������� �� �������
        [TestCase(new int[] { 1, 2, 3, 0 }, 1, ExpectedResult = 2)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 3, ExpectedResult = 3)]
        [TestCase(new int[] { 8 }, 0, ExpectedResult = 8)]
        public int TestFindByIndex(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            return actual[b];
        }

        //���� ��� �������� ������� �� ��������
        [TestCase(new int[] { 1, 2, 3, 0 }, 3, ExpectedResult = 2)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 4, ExpectedResult = 4)]
        [TestCase(new int[] { 8 }, 0, ExpectedResult = 0)]
        public int TestFindIndex(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            return actual.FindIndex(b);
        }

        //���� ��� ��������� �������� �� �������
        [TestCase(new int[] { 1, 2, 3, 0 }, 2, 5, ExpectedResult = new int[] { 1, 2, 5, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, 1, -8, ExpectedResult = new int[] { 0, -8, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 0, 15, ExpectedResult = new int[] { 15 })]
        public int[] TestChangesByIndex(int[] a, int b, int c)
        {
            ArrayList actual = new ArrayList(a);
            actual[b] = c;
            return actual.ReturnArray();
        }

        //���� ��� ������� �������
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 0, 3, 2, 1 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = new int[] { 4, 3, 5, 2, 0 })]
        [TestCase(new int[] { 8 }, ExpectedResult = new int[] { 8 })]
        public int[] TestReverseArray(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            actual.ReverseArray();
            return actual.ReturnArray();
        }

        //���� ��� ���������� ������������� ��������
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 3)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = 5)]
        [TestCase(new int[] { 8 }, ExpectedResult = 8)]
        public int TestFindMax(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.FindMax();
        }

        //���� ��� ���������� ������������ ��������
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = 0)]
        [TestCase(new int[] { 8 }, ExpectedResult = 8)]
        public int TestFindMin(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.FindMin();
        }

        //���� ��� ���������� ������� ������������� ��������
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 2)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = 2)]
        [TestCase(new int[] { 8 }, ExpectedResult = 0)]
        public int TestFindIndexMax(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.FindIndexMax();
        }

        //���� ��� ���������� ������� ������������ ��������
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = 3)]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = 0)]
        [TestCase(new int[] { 8 }, ExpectedResult = 0)]
        public int TestFindIndexMin(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.FindIndexMin();
        }


        //���� ��� ���������� �� �����������
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 0, 1, 2, 3 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = new int[] { 0, 2, 3, 4, 5 })]
        [TestCase(new int[] { 8 }, ExpectedResult = new int[] { 8 })]
        public int[] TestSortInAscending(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            actual.SortInAscending();
            return actual.ReturnArray();
        }

        //���� ��� ���������� �� ��������
        [TestCase(new int[] { 1, 2, 3, 0 }, ExpectedResult = new int[] { 3, 2, 1, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4 }, ExpectedResult = new int[] { 5, 4, 3, 2, 0 })]
        [TestCase(new int[] { 8 }, ExpectedResult = new int[] { 8 })]
        public int[] TestSortInDescending(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            actual.SortInDescending();
            return actual.ReturnArray();
        }

        //���� ��� �������� �� ��������
        [TestCase(new int[] { 1, 2, 3, 0 }, 5, ExpectedResult = new int[] { 1, 2, 3, 0 })]
        [TestCase(new int[] { 0, 2, 5, 3, 4, 0 }, 0, ExpectedResult = new int[] { 2, 5, 3, 4 })]
        [TestCase(new int[] { 8 }, 8, ExpectedResult = new int[] { })]
        public int[] TestRemoveByValue(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            actual.RemoveByValue(b);
            return actual.ReturnArray();
        }
    }
}
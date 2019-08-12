using System;

namespace DataStruct
{

    public class CompareSort
    {
        public void BubbleSort(int[] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                for (int j = arrays.Length - 1; j < arrays.Length - i; j--)
                {
                    if (arrays[j - 1] > arrays[j])
                    {
                        var temp = arrays[j - 1];
                        arrays[j - 1] = arrays[j];
                        arrays[j] = temp;
                    }
                }
            }
        }

        public void InsetSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var j = i - 1;
                var currentValue = array[i];
                for (; j >= 0; j--)
                {
                    if (array[j] > currentValue)
                    {
                        //array[j] = array[j];
                        array[j + 1] = array[j];
                    }
                    else
                    {
                        break;
                    }
                }

                // array[i] = currentValue;
                array[j + 1] = currentValue;
            }
        }
        public void SelectSort(int[] array)
        {
            var minIndex = -1;
            var minValue = 0;
            // for (int i = 0; i < array.Length; i++)
            for (int i = 0; i < array.Length / 2; i++)
            {
                // var minIndex = 0;
                // var minIndex = -1;
                // var minValue = array[i];

                minIndex = -1;
                minValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < minValue)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }

                // var current = array[i];
                // array[i] = array[minIndex];
                // array[minIndex] = current;

                if (minIndex != -1)
                {
                    array[minValue] = array[i];
                    array[i] = minValue;
                }
            }
        }

        public void MergeSort(int[] array)
        {


        }

        public void MergeSortSub(int[] array, int p, int r)
        {
            //递归终止条件，不用再继续分解
            if (p >= r) return;

            var q = (p + r) / 2;

            MergeSortSub(array, p, q);
            MergeSortSub(array, q + 1, r);
            Merge(array,p, q, r);
        }

        public void Merge(int[] array, int p, int q, int r)
        {
            var i = p;
            var j = q + 1;
            var k = 0;

            var temp = new int[r];
            while (i <= q && j <= r)
            {
                if (array[i] <= array[j])
                {
                    temp[k++] = array[i++];
                }
                else
                {
                    temp[k++] = array[j++];
                }
            }

            var start = i; var end = q;
            if (j <= r)
            {
                start = j;
                end = r;
            }

            while (start <= end)
            {
                temp[k++] = array[start++];
            }

            for (int a = 0; a < r; a++)
            {
                array[a] = temp[a];
            }
        }
    }

    public class LinkedList
    {
        Node head;

        public class Node
        {
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
            public int Data { get; set; }
            public Node Next { get; set; }
        }

        public void AddNode(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }
        }

        //将当前节点的 next 指针改为指向前一个元素。
        //由于节点没有引用其上一个节点，因此必须事先存储其前一个元素。
        //在更改引用之前，还需要另一个指针来存储下一个节点。
        public void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node next = null;

            while (current != null)
            {
                // Store next 
                next = current.Next;
                // Reverse current node's pointer 
                current.Next = prev;
                // Move pointers one position ahead. 
                prev = current;
                //modify the point of current
                current = next;
            }

            head = prev;
        }
        //使用快慢指针的方式，找到中间结点
        public Node GetMiddlePoint()
        {
            Node fast = head;
            Node slow = head;
            while (fast != null && fast.Next != null)//fast 当有偶数个结点时用于退出循环，fast.Next 用于有奇数个结点时退出循环
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }

        public string GetLinked()
        {
            Node current = head;
            var result = string.Empty;

            while (current != null)
            {
                result += $"{current.Data} ";
                current = current.Next;
            }
            result = result.TrimEnd(' ');

            return result;
        }

    }
}


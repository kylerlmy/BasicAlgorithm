using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Basic.Sort
{
    public class QueckSort
    {
        public void Sort(int[] array, int n)
        {
            InternalSort(array, 0, n - 1);
        }
        private void InternalSort(int[] array, int p, int r)
        {
            if (p >= r) return;
            var q = Partition(array, p, r);
            // InternalSort(array, p, q );
            InternalSort(array, p, q - 1);//注意这里是q-1，因为被分为3部门，p ~ q-1, q, q+1 ~ r
            InternalSort(array, q + 1, r);
        }

        private int Partition(int[] array, int p, int r)
        {
            var pivot = array[r];
            var i = p;

            for (int j = p; j < array.Length; j++)
            {
                if (array[j] < pivot)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }

            array[r] = array[i];
            array[i] = pivot;

            return i;
        }
    }

}






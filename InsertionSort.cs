using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class InsertionSort
    {
        public void Display()

        {
            int[] arr = new int[5] { 8, 9, 85, 12, 99 };


            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;
                while (j >= 0 && current < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = current;
            }
            Console.WriteLine("SORTED ARRAY");
            foreach (int p in arr)
            {
                Console.Write(p + " ");
            }



        }
    }
}






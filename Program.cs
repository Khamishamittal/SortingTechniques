namespace SortingTechniques
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sorting Techniques");

            int[] arr = { 8, 4, 21, 88, 45, 125, 12 };

            Console.WriteLine("Array before sorting:");
            MergeSort.PrintArray(arr);

            MergeSort.mergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nArray after Merge sort:");
            MergeSort.PrintArray(arr);
        }
    }
}

    


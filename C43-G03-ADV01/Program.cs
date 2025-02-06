namespace C43_G03_ADV01
{
    internal class Program
    {
        static void OptimizedBubble(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                     
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true; 
                    }
                }

              
                if (!swapped)
                    break;
            }
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }

        static void Main(string[] args)
        {


            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original array:");
            PrintArray(arr);

            OptimizedBubble(arr);

            Console.WriteLine("Sorted array:");
            PrintArray(arr);
        }
    }
}

namespace _242252
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test = new int[] { 1, 3, 5, 4, 2, 1, 5, 2, 8, 2 };
            Console.WriteLine(CountSearch(test, 2));
        }
        public static int CountSearch(int[] array, int target)
        { int count = 0;
            int left = 0;
            int right = array.Length - 1;
            while (left <= right) 
            { int mid = left + (right - left) / 2;
                if (array[mid] == target)
                    count++;
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return count;
        }
    }
}

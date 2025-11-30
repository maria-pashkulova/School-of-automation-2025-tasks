namespace BiggestElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 13, -6, 18, 195, 2, 0, 16 };

            Console.WriteLine("Original numbers: " + string.Join(", ", numbers));

            int biggestNum = FindBiggestNumAndSortDescending(numbers);

            Console.WriteLine("Biggest number: " + biggestNum);
            Console.WriteLine("Numbers sorted in descending order: " + string.Join(", ", numbers));

        }

        public static int FindBiggestNumAndSortDescending(int[] numbers)
        {

            //1. Find the biggest number of the array without sorting
            /*int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;*/

            //2. Find the biggest number of the array and sort it in descending order using selection sort algorithm

            for (int i = 0; i < numbers.Length; i++)
            {
                //Find the index of the maximum element in the remaining unsorted array
                int maxIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                // Swap the found maximum element with the first element of the unsorted subarray
                if (maxIndex != i)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[maxIndex];
                    numbers[maxIndex] = temp;
                }
            }

            return numbers[0]; // The biggest number is now the first element after sorting
        }

        //Alternative method using built-in sort and lambda expression
        public static void SortDescending(int[] arr)
        {
            Array.Sort(arr, (a, b) => b.CompareTo(a));
        }
    }
}

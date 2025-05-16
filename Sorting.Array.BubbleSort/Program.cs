namespace Sorting.Array.BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define array
            int[] numbers = { 200, 80, 108, 44, 90, 77, 33, 50, 41 };
            int swap;

            Console.WriteLine("Array before Sorting : ");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-------------------------------------");
            for (int k = 0; k < numbers.Length - 1; k++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        //use swap temporary
                        swap = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = swap;
                    }
                }
            }

            Console.WriteLine("Array after Sorting : ");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}

using System;

class Program
{
    //Поразрядная сортировка с поддержкой отрицательных чисел
    static long[] SortL(long[] arr)
    {
        {
            if (arr == null || arr.Length == 0)
                return arr;

            int i, j;
            var tmp = new long[arr.Length];

            for (int shift = sizeof(long) * 8 - 1; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    var move = (arr[i] << shift) >= 0;
                    System.Console.WriteLine($"{arr[i]} << {shift} = {arr[i] << shift}");

                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
                Console.WriteLine(string.Join(", ", arr));
            }

            return arr;
        }
    }


    static void Main(string[] args)
    {
        long[] arr = { 10, 34, 28, 83, 0, 9, 12, 44, 108, 93, 14 };

        Console.WriteLine("Входные данные: {0}", string.Join(", ", arr));

        // System.Console.WriteLine($" 9 << 1  -> {9 << 1}");
        // Console.WriteLine("1 << 1 = " + (1 << 1));
        // Console.WriteLine("1 << 2 = " + (1 << 2));
        // Console.WriteLine("1 << 3 = " + (1 << 3));
        Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", SortL(arr)));
    }
}
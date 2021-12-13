using System;

namespace csharp_study_371p
{
    class MainApp
    {
        static void PrintArray(System.Array array)
        {
            foreach (var e in array)
                Console.Write(e);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            char[] array =  new char['Z' - 'A' + 1];
            for (int i = 0; i < array.Length; i++)
                array[i] = (char)('A' + i);

            PrintArray(array[..]); // 0번째부터 마지막까지
            PrintArray(array[5..]); // 5번째부터 끝까지

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]); // 5번째부터 9번째까지

            Index last = ^0;
            Range range_5_last = 5..last;
            PrintArray(array[^4..^1]); // 끝에서 4번째부터 끝에서 2번째까지

            
        }
    }
}

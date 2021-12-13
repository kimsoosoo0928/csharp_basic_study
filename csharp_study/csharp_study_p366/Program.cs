using System;

namespace csharp_study_p366
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }
        
        private static void Print(int value)
        {
            Console.Write($"{value}");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 90, 34 };

            foreach (int score in scores)
                Console.WriteLine($"{score}");
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}"); // 배열의 차원을 반환합니다.

            Console.WriteLine($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}"); // 이진 탐색을 수행합니다.

            Console.WriteLine($"Linear Search : 90 is ay " + $"{Array.IndexOf(scores, 90)}"); // 배열에서 찾고자 하는 특정 데이터의 인덱스를 반환합니다.

            Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}"); // 
            int index = Array.FindIndex<int>(scores, (scores) => scores < 60);

            scores[index] = 61;
            Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            Console.WriteLine("Old length of scores : " + $"{scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New Length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));

            Array.Clear(scores, 3, 7);
            





        }
    }
}

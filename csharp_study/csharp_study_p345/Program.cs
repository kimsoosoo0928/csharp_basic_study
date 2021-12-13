// 무명형식
// 무명 형식은 형식의 선언과 동시에 인스턴스를 할당합니다. 인스턴스를 만들고 다시는 사용하지 않을 때 무명 형식이 요긴합니다. 
// 무명 형식에서 주의할 점이 있는데, 그것은 무명 형식의 프로퍼티에 할당된 값은 변경 불가능하다는 사실입니다. 한마디로 무명 형식의 인스턴스가 만들어지고 난 다음에는 읽기만 할 수 있다는 이야기 입니다.

using System;
 3
    
    
    +swsxs3sxsxsssmousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine($"Name:{a.Name}, Age:{a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };

            Console.Write($"SUbject:{b.Subject}, Scores:");
            foreach (var score in b.Scores)
                Console.Write($"{score}");

            Console.WriteLine();
        }
    }
}w 
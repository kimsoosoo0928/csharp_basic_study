using System;
using System.Collections;

namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;
        // 컬렉션의 현재 위치를 다루는 변수이다. 초기값은 0이 아닌 -1이다.
        // 0은 배열의 첫 번째 요소를 가리키는 수이다.
        // position이 이 값(0)을 갖고 있을 때 foreach 문이 첫 번째 반복을 수행하면 MoveNext()메소드를 실행하고, 이때 position이 1이 되어 두 번째 요소를 가져오는 문제가 생깁니다.

        public MyList()
        {
            array = new int[3]; // int형 크기가 3인 배열 선언
        }

        public int this[int index] // int형 index this 메서드 선언
        {
            get
            {
                return array[index]; // array의 index값 반환
            }

            set
            {
                if (index >= array.Length) // 만약 index가 배열의 크기보다 크거나 같으면 
                {
                    Array.Resize<int>(ref array, index + 1); // array를 리사이즈, array를 참고하고 index에 + 1을 적용  ???
                    Console.WriteLine($"Array Resized : {array.Length}"); // array.Length를 출력 
                }

                array[index] = value; // index의 해당하는 array를 value로 정의
            }

        }
        // IEnumerator의 멤버
        public object Current // IEnumerator로부터 상속받은 Current 프로퍼티는 현재 위치의 요소를 반환합니다.
        {
            get
            {
                return array[position]; // 배열의 현재위치 반환
            }
        }

        // IEnumerator의 멤버
        public bool MoveNext() // IEnumerator로부터 상속받은 MoveNext() 메소드, 다음 위치의 요소로 이동합니다. 
        {
            if (position == array.Length - 1) 
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length); // ??
        }

        // IEnumerator의 멤버
        public void Reset() // IEnumerator로부터 상속받은 Reset() 메소드, 요소의 위치를 첫 요소의 "앞"으로 옮깁니다.
        {
            position = -1; 

        }

        // IEnumerable 멤버 
        public IEnumerator GetEnumerator()
        {
            return this;
        }



        
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                Console.WriteLine(e);
        }
    }
}
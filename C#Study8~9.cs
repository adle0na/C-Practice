using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Part 8 배열
    /*
    int[] exp = { 50, 100, 150, 200, 250, 300 }; // int형 배열로 exp 선언, 배열 값은 50, 100, 150, 200, 250, 300을 가짐

    private void Start()
    {
       
        // print(exp[1]); C#의 첫번째 배열 index값은 0부터 시작하기 때문에 출력값은 100이 나옴

        exp[5] = 500; // 배열의 원소의 값은 바꿀수있지만 배열의 크기는 바꿀수없다 ex) exp[6] = 100; 같이 새로 추가할순없음

       for(int i = 0; i < 5; i++) // 반복문 (int형 변수 i를 5가될때까지 증가)
        {
            print(exp[i]); // (exp 배열의 index값으로 i를 넣어 출력)
        }

       for(int i = 0; i < exp.Length; i++) // (마찬가지로 int형 변수 i를 0부터 시작해서 exp배열의 길이전만큼 증가)
        {
            print(exp[i]);
        }
   

        // 1차원 배열
        int[] exp = { 50, 100, 150, 200, 250, 300 }; // int형 배열 exp 선언 6개의 index값 지정

        int[] array = new int[10]; // int형 배열 array의 크기 10 선언

        // 2차원 배열
        int[,] array2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } }; // int형이고 2차원 배열인 array2 선언

        // 3차원 배열
        int[,,] array3 = { { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 }, { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } } };

        void Start()
        {
            // array2 = new int[10];  array2배열 크기 10 선언
            // array2 = new int[exp.Length]; array2 배열의 크기를 exp 배열의 길이와 같도록 선언

            print(array2[1, 3]); // 두번째 배열의 3번째 index = 40 

            print(array2[0, 1]); // 첫번째 배열의 2번째 index = 2

            print(array3[1, 1, 2]); // 두번째 배열의 두번째배열의 3번째 index = 30

            print(array3[0, 0, 3]); // 첫번째 배열의 첫번째배열의 4번째 index = 4
        }
    }
        */

    // Part 9 컬렉션

    int[] exp = new int[5] { 1, 2, 3, 4, 5 }; // int형 배열 exp에 크기와 index값 선언

    ArrayList arrayList = new ArrayList(); // Class ArrayList 사용 선언

    void Start()
    {
        arrayList.Add(1); // ArrayList클래스 내부의 Add함수 실행 (함수 = 메소드)
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add("가나다라");
        arrayList.Add(4.5);

        // arrayList.RemoveAt(3);  인덱스 하나를 지움

        // arrayList.RemoveRange(1, 3) 인덱스의 범위를 지정해서 지움

        // print(arrayList.Contains("가나다라")); 특정 원소가 있는지 없는지 체크

        for (int i = 0; i < arrayList.Count; i++) // 반복문 (int형 i를 0부터 시작해서 arrayList의 개수만큼 증가)
        {
            print(arrayList[i]); // ArrayList는 Length가 아니라 Count사용
        }

        // List와 ArrayList의 차이점 List는 반드시 특정자료형을 가진 값만 추가가능
    }

}

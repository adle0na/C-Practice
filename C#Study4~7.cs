using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    /*
    // byte 정수 자료형 (0~255) 1바이트 (음수가 없음)
    // sbyte 정수 자료형 (-128~+127) - 1바이트
    // short 정수 자료형 (-3만 ~+3만) - 2바이트
    // integer 정수 자료형 (-20억~+20억) - 4바이트
    // long 정수 자료형 - 8바이트

    // ushort 등 앞에 u를 붙이면 음수값을 포기하고 그만큼의 이득값을 얻는다

    // float 실수 자료형 (실수뒤에 f붙여 사용)
    // double 실수 자료형 (실수뒤에 아무것도 안붙임)
    // decimal 실수 자료형 (실수뒤에 m붙여 사용

    // 문자 자료형
    // string s = "아무거나";
    // char c = 'A'; (유니코드 사용가능, 반드시 한글자만 기억가능)

    // long과 int의 서순
    
    int a = 100;
    long b = 100;
    
    long sum;

    Long은 int를 포함하고있다
    위에서 int sum;은 사용불가능
  

    // float과 int같이 정수와 실수를 같이 사용할 경우
   
    int a = 100;
    float b = 100.15f;

    int sum; ( or float sum; )
    
    sum = ( a + b );
    위의 코드는 sum = (int)(a + b);
                sum = (float(a + b); 로 사용가능하다 이와같이 강제로 바꾸는 방법을 Cast라고 한다
    
  

    // int와 string같은 문자열

    int a = 100;  여기서도 "100"으로 바꿔 문자열로 변환가능
    string b;

    b = a
    이와 같은 경우에선 a뒤에 .ToString();을 붙여 강제로 문자열로 변환가능
    a = b
    반대의 경우엔 b를 int.Parse(b);로 사용가능 (double.Parse(b), short.Parse(b)등등 가능)
    자료형.Parse();는 ()의 값을 앞에서 지정한 자료형으로 형변환한다

    근데 강제 형변환은 오류 발생률이 높기 때문에 조심해서 사용할것
 
    // bool 변수 = true, false 값만 사용가능

    // Part 3 함수
    // int자료형을 가진 변수 intValue 선언
    int intValue; // 소문자로 시작, 길어지면 중간부터 대문자 추천
    // float자료형을 가진 변수 floatValue 10.5값을 지정
    float floatValue = 10.5f;
  
    float floatValue2 = 20.5f;

    // float자료형의 _parameter1,2 값과 string문자형을 디폴트 값을 "Default Value" 로 지정하여 가진 FloatToInt 함수 선언
    void FloatToInt(float _parameter, float _parameter2, string _stringParam = "Default Value")
    {
        
        //intValue 변수에 floatValue값을 int자료형으로 형변환하여 삽입
        intValue = (int)_parameter;
        

        //intValue 변수에 _parameter 1, 2를 합하여 int형으로 형변환
        intValue = (int)(_parameter + _parameter2);

        // 최종 intValue값 호출
        print(intValue);
        // 최종 _stringParam값 호출
        print(_stringParam);
    }
    
    void Start ()
    {
      
        floatValue는 FloatToInt함수의 _parameter값에 삽입, 마찬가지로 floatValue2는 _parameter2값에 삽입
        문자열인 "텍스트"를 마찬가지로 문자형인 _stringParam에 삽입
        FloatToInt(floatValue, floatValue2, "텍스트");
       
        // FloatToInt함수의 3번째 값인 _stringParam값은 디폴트 값이 지정이 되어있으므로 생략가능
        FloatToInt(floatValue, floatValue2);
    }
    

    // Part 4 지정자

    int a = 5; // 멤버 변수, 전역 변수 ( 자연스럽게 앞에 private는 생략됨 )
    // private는 다른 클래스에서 사용 불가능
    // public은 다른 클래스에서도 사용 가능 보안적인 측면에서 불안함
    // public 이후 static 선언시 변수를 공유자원으로 사용 이름이 같은 다른 변수값도 모두 같은 값
    // 클래스는 변수 선언시에 값을 할당해줘야함

    void Abc() // 반환값을 사용 안하는 함수 Abc 호출
    {
        int a = 5; // 지역 변수의 우선순위가 높기 때문에
        a = 6; // 6으로 선언 할시 멤버 변수는 무시되고 6의 값을 받음
        // 지역 변수는 시작시엔 없다가 함수가 실행될때 생성되며 함수가 종료되면 같이 소멸


        int b = 5; // int형 b는 지역 변수로 다른 함수에선 사용 할 수 없음
        print(b);
    }
    
    void Abc2() // 반환값 사용 안하는 함수 Abc2 호출
    {
        int b = 5; // 지역 변수
        print(b);
    }

    void Abc3(float _parameter) // 마찬가지로 반환값 사용 안하는 Abc3 함수는 실수형float 값의 _parameter라는 매개변수를 지님
    {

    }


    // Part 5 연산자

    // 기본연산자 +, -, *, /, %, = (대입연산자)

    int a = 10;
    int b = 10;
    bool c = false;

    void Start()
    {
        //print(a + b); 

        //a = a + b; // a += b;로 사용가능

        // ?=와 같이 =앞에 다른 연산자가 붙으면 복합 대입 연산자
        // c = c + 1 은 c += 1 과 같고 c++, ++c 와도 같다 

        c = (a == b); // 관계 연산자 ==, >=, <=, !=
        print(c);

        // 논리연산자 관계연산자
        // && 둘다 true일 경우만 true 출력 (논리값 AND)
        // || 하나라도 true일 경우 true 출력 (논리값 OR)
        
        // 비트연산자 &(AND) |(OR) ^(XOR) ~(NOT) 비트 이동 <<(*과 비슷) >>(/와 비슷) 요기는 어려움
    }
    */

    // Part 6 조건문

    /* if문
    int input = 5;
    int num = 10;

    bool result;

    void Start()
    {
        if (input == num)
        {
            print("같음");
        }
        else if (input > num) // 또 if문을 사용할경우 자원낭비이므로 else if문 사용하여 묶어줌
        {
            print("input이큼");
        }
        else (input < num) // 위의 모든 조건문을 검증한후 나머지 결과값 출력
                {
            print("num이큼")
        }
    }

    // Switch 문
    int input = 11;
    int num = 10;

    bool result;

    void Start()
    {
        switch (input)
        {
            case 10;
                print("값이 10입니다");
                break; // 조건실행후 파괴
            case 11;
                print("값이 11입니다");
                break;
            case 12;
                print("값이 12입니다");
                break;
            default // else와 마찬가지로 걸리는 조건이 없을경우
        }
    }
   
    
    // 삼항연산자
    // int temp = input == num ? 50 : 100; (input 값이 num과 같냐? true 50 출력 false 100 출력) 
     */


    // Part 7 반복문

    /*
    // for문
    int num = 0;

    void Start()
    {
        for(int i = 0; i < 10; i++) // 위에서 초기값 선언을 했기에 int i = 0; 은 생략 가능
        {
            print(i);
            // if(num >= 10) 조건문을 통하여 반복문 탈출 가능
              // break;

            // 이중for문일 경우 가장 안쪽 for문에서 break 발생시 가장 바깥의 for문 탈출
            // break 대신 continue를 사용할 경우 해당회차만 종료
        }
    }

    // While 문

    int num = 0;

    void Start()
    {
        while (true) // 참이 될때까지 반복한다
        {
            num++; // num값 증가
            if (num > 10) // 조건문 (10보다 커지면)
                break; 종료

            print(num);
        }
    }
    // for문은 반복횟수가 명확할때 사용하면 좋음
    // While문은 반복횟수가 명확하지 않을때


    // do while문

    int num = 0;

    void Start()
    {
        do // 반복문 실행
        {
            num++; // num값 증가
            print(num); // num값 출력
        } while (num < 10); // num값이 10이 되기 전까지 실행
    }
 
    // 1회차는 절대 실행후 조건 확인


    // foreach문
    // 덩어리를 낱개로 쪼개주는 반복문

    string text = "가나다라마바사";

    void Start()
    {
        foreach(char ab in text) 
        {
            print(ab);
        }
    }
    */
}

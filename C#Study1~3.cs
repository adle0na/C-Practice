using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
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
    /* 
    int a = 100;
    long b = 100;
    
    long sum;

    Long은 int를 포함하고있다
    위에서 int sum;은 사용불가능
    */

    // float과 int같이 정수와 실수를 같이 사용할 경우
    /*
    int a = 100;
    float b = 100.15f;

    int sum; ( or float sum; )
    
    sum = ( a + b );
    위의 코드는 sum = (int)(a + b);
                sum = (float(a + b); 로 사용가능하다 이와같이 강제로 바꾸는 방법을 Cast라고 한다
    
    */

    // int와 string같은 문자열
    /*
    int a = 100;  여기서도 "100"으로 바꿔 문자열로 변환가능
    string b;

    b = a
    이와 같은 경우에선 a뒤에 .ToString();을 붙여 강제로 문자열로 변환가능
    a = b
    반대의 경우엔 b를 int.Parse(b);로 사용가능 (double.Parse(b), short.Parse(b)등등 가능)
    자료형.Parse();는 ()의 값을 앞에서 지정한 자료형으로 형변환한다

    근데 강제 형변환은 오류 발생률이 높기 때문에 조심해서 사용할것
    */
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
        /*
        //intValue 변수에 floatValue값을 int자료형으로 형변환하여 삽입
        intValue = (int)_parameter;
        */

        //intValue 변수에 _parameter 1, 2를 합하여 int형으로 형변환
        intValue = (int)(_parameter + _parameter2);

        // 최종 intValue값 호출
        print(intValue);
        // 최종 _stringParam값 호출
        print(_stringParam);
    }
    
    void Start ()
    {
        /*
        floatValue는 FloatToInt함수의 _parameter값에 삽입, 마찬가지로 floatValue2는 _parameter2값에 삽입
        문자열인 "텍스트"를 마찬가지로 문자형인 _stringParam에 삽입
        FloatToInt(floatValue, floatValue2, "텍스트");
        */
        // FloatToInt함수의 3번째 값인 _stringParam값은 디폴트 값이 지정이 되어있으므로 생략가능
        FloatToInt(floatValue, floatValue2);
    }
}

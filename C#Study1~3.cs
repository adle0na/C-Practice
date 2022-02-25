using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // byte ���� �ڷ��� (0~255) 1����Ʈ (������ ����)
    // sbyte ���� �ڷ��� (-128~+127) - 1����Ʈ
    // short ���� �ڷ��� (-3�� ~+3��) - 2����Ʈ
    // integer ���� �ڷ��� (-20��~+20��) - 4����Ʈ
    // long ���� �ڷ��� - 8����Ʈ

    // ushort �� �տ� u�� ���̸� �������� �����ϰ� �׸�ŭ�� �̵氪�� ��´�

    // float �Ǽ� �ڷ��� (�Ǽ��ڿ� f�ٿ� ���)
    // double �Ǽ� �ڷ��� (�Ǽ��ڿ� �ƹ��͵� �Ⱥ���)
    // decimal �Ǽ� �ڷ��� (�Ǽ��ڿ� m�ٿ� ���

    // ���� �ڷ���
    // string s = "�ƹ��ų�";
    // char c = 'A'; (�����ڵ� ��밡��, �ݵ�� �ѱ��ڸ� ��ﰡ��)

    // long�� int�� ����
    /* 
    int a = 100;
    long b = 100;
    
    long sum;

    Long�� int�� �����ϰ��ִ�
    ������ int sum;�� ���Ұ���
    */

    // float�� int���� ������ �Ǽ��� ���� ����� ���
    /*
    int a = 100;
    float b = 100.15f;

    int sum; ( or float sum; )
    
    sum = ( a + b );
    ���� �ڵ�� sum = (int)(a + b);
                sum = (float(a + b); �� ��밡���ϴ� �̿Ͱ��� ������ �ٲٴ� ����� Cast��� �Ѵ�
    
    */

    // int�� string���� ���ڿ�
    /*
    int a = 100;  ���⼭�� "100"���� �ٲ� ���ڿ��� ��ȯ����
    string b;

    b = a
    �̿� ���� ��쿡�� a�ڿ� .ToString();�� �ٿ� ������ ���ڿ��� ��ȯ����
    a = b
    �ݴ��� ��쿣 b�� int.Parse(b);�� ��밡�� (double.Parse(b), short.Parse(b)��� ����)
    �ڷ���.Parse();�� ()�� ���� �տ��� ������ �ڷ������� ����ȯ�Ѵ�

    �ٵ� ���� ����ȯ�� ���� �߻����� ���� ������ �����ؼ� ����Ұ�
    */
    // bool ���� = true, false ���� ��밡��

    // Part 3 �Լ�
    // int�ڷ����� ���� ���� intValue ����
    int intValue; // �ҹ��ڷ� ����, ������� �߰����� �빮�� ��õ
    // float�ڷ����� ���� ���� floatValue 10.5���� ����
    float floatValue = 10.5f;
  
    float floatValue2 = 20.5f;

    // float�ڷ����� _parameter1,2 ���� string�������� ����Ʈ ���� "Default Value" �� �����Ͽ� ���� FloatToInt �Լ� ����
    void FloatToInt(float _parameter, float _parameter2, string _stringParam = "Default Value")
    {
        /*
        //intValue ������ floatValue���� int�ڷ������� ����ȯ�Ͽ� ����
        intValue = (int)_parameter;
        */

        //intValue ������ _parameter 1, 2�� ���Ͽ� int������ ����ȯ
        intValue = (int)(_parameter + _parameter2);

        // ���� intValue�� ȣ��
        print(intValue);
        // ���� _stringParam�� ȣ��
        print(_stringParam);
    }
    
    void Start ()
    {
        /*
        floatValue�� FloatToInt�Լ��� _parameter���� ����, ���������� floatValue2�� _parameter2���� ����
        ���ڿ��� "�ؽ�Ʈ"�� ���������� �������� _stringParam�� ����
        FloatToInt(floatValue, floatValue2, "�ؽ�Ʈ");
        */
        // FloatToInt�Լ��� 3��° ���� _stringParam���� ����Ʈ ���� ������ �Ǿ������Ƿ� ��������
        FloatToInt(floatValue, floatValue2);
    }
}

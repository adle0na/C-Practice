using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    /*
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
    
    int a = 100;
    long b = 100;
    
    long sum;

    Long�� int�� �����ϰ��ִ�
    ������ int sum;�� ���Ұ���
  

    // float�� int���� ������ �Ǽ��� ���� ����� ���
   
    int a = 100;
    float b = 100.15f;

    int sum; ( or float sum; )
    
    sum = ( a + b );
    ���� �ڵ�� sum = (int)(a + b);
                sum = (float(a + b); �� ��밡���ϴ� �̿Ͱ��� ������ �ٲٴ� ����� Cast��� �Ѵ�
    
  

    // int�� string���� ���ڿ�

    int a = 100;  ���⼭�� "100"���� �ٲ� ���ڿ��� ��ȯ����
    string b;

    b = a
    �̿� ���� ��쿡�� a�ڿ� .ToString();�� �ٿ� ������ ���ڿ��� ��ȯ����
    a = b
    �ݴ��� ��쿣 b�� int.Parse(b);�� ��밡�� (double.Parse(b), short.Parse(b)��� ����)
    �ڷ���.Parse();�� ()�� ���� �տ��� ������ �ڷ������� ����ȯ�Ѵ�

    �ٵ� ���� ����ȯ�� ���� �߻����� ���� ������ �����ؼ� ����Ұ�
 
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
        
        //intValue ������ floatValue���� int�ڷ������� ����ȯ�Ͽ� ����
        intValue = (int)_parameter;
        

        //intValue ������ _parameter 1, 2�� ���Ͽ� int������ ����ȯ
        intValue = (int)(_parameter + _parameter2);

        // ���� intValue�� ȣ��
        print(intValue);
        // ���� _stringParam�� ȣ��
        print(_stringParam);
    }
    
    void Start ()
    {
      
        floatValue�� FloatToInt�Լ��� _parameter���� ����, ���������� floatValue2�� _parameter2���� ����
        ���ڿ��� "�ؽ�Ʈ"�� ���������� �������� _stringParam�� ����
        FloatToInt(floatValue, floatValue2, "�ؽ�Ʈ");
       
        // FloatToInt�Լ��� 3��° ���� _stringParam���� ����Ʈ ���� ������ �Ǿ������Ƿ� ��������
        FloatToInt(floatValue, floatValue2);
    }
    

    // Part 4 ������

    int a = 5; // ��� ����, ���� ���� ( �ڿ������� �տ� private�� ������ )
    // private�� �ٸ� Ŭ�������� ��� �Ұ���
    // public�� �ٸ� Ŭ���������� ��� ���� �������� ���鿡�� �Ҿ���
    // public ���� static ����� ������ �����ڿ����� ��� �̸��� ���� �ٸ� �������� ��� ���� ��
    // Ŭ������ ���� ����ÿ� ���� �Ҵ��������

    void Abc() // ��ȯ���� ��� ���ϴ� �Լ� Abc ȣ��
    {
        int a = 5; // ���� ������ �켱������ ���� ������
        a = 6; // 6���� ���� �ҽ� ��� ������ ���õǰ� 6�� ���� ����
        // ���� ������ ���۽ÿ� ���ٰ� �Լ��� ����ɶ� �����Ǹ� �Լ��� ����Ǹ� ���� �Ҹ�


        int b = 5; // int�� b�� ���� ������ �ٸ� �Լ����� ��� �� �� ����
        print(b);
    }
    
    void Abc2() // ��ȯ�� ��� ���ϴ� �Լ� Abc2 ȣ��
    {
        int b = 5; // ���� ����
        print(b);
    }

    void Abc3(float _parameter) // ���������� ��ȯ�� ��� ���ϴ� Abc3 �Լ��� �Ǽ���float ���� _parameter��� �Ű������� ����
    {

    }


    // Part 5 ������

    // �⺻������ +, -, *, /, %, = (���Կ�����)

    int a = 10;
    int b = 10;
    bool c = false;

    void Start()
    {
        //print(a + b); 

        //a = a + b; // a += b;�� ��밡��

        // ?=�� ���� =�տ� �ٸ� �����ڰ� ������ ���� ���� ������
        // c = c + 1 �� c += 1 �� ���� c++, ++c �͵� ���� 

        c = (a == b); // ���� ������ ==, >=, <=, !=
        print(c);

        // �������� ���迬����
        // && �Ѵ� true�� ��츸 true ��� (���� AND)
        // || �ϳ��� true�� ��� true ��� (���� OR)
        
        // ��Ʈ������ &(AND) |(OR) ^(XOR) ~(NOT) ��Ʈ �̵� <<(*�� ���) >>(/�� ���) ���� �����
    }
    */

    // Part 6 ���ǹ�

    /* if��
    int input = 5;
    int num = 10;

    bool result;

    void Start()
    {
        if (input == num)
        {
            print("����");
        }
        else if (input > num) // �� if���� ����Ұ�� �ڿ������̹Ƿ� else if�� ����Ͽ� ������
        {
            print("input��ŭ");
        }
        else (input < num) // ���� ��� ���ǹ��� �������� ������ ����� ���
                {
            print("num��ŭ")
        }
    }

    // Switch ��
    int input = 11;
    int num = 10;

    bool result;

    void Start()
    {
        switch (input)
        {
            case 10;
                print("���� 10�Դϴ�");
                break; // ���ǽ����� �ı�
            case 11;
                print("���� 11�Դϴ�");
                break;
            case 12;
                print("���� 12�Դϴ�");
                break;
            default // else�� ���������� �ɸ��� ������ �������
        }
    }
   
    
    // ���׿�����
    // int temp = input == num ? 50 : 100; (input ���� num�� ����? true 50 ��� false 100 ���) 
     */


    // Part 7 �ݺ���

    /*
    // for��
    int num = 0;

    void Start()
    {
        for(int i = 0; i < 10; i++) // ������ �ʱⰪ ������ �߱⿡ int i = 0; �� ���� ����
        {
            print(i);
            // if(num >= 10) ���ǹ��� ���Ͽ� �ݺ��� Ż�� ����
              // break;

            // ����for���� ��� ���� ���� for������ break �߻��� ���� �ٱ��� for�� Ż��
            // break ��� continue�� ����� ��� �ش�ȸ���� ����
        }
    }

    // While ��

    int num = 0;

    void Start()
    {
        while (true) // ���� �ɶ����� �ݺ��Ѵ�
        {
            num++; // num�� ����
            if (num > 10) // ���ǹ� (10���� Ŀ����)
                break; ����

            print(num);
        }
    }
    // for���� �ݺ�Ƚ���� ��Ȯ�Ҷ� ����ϸ� ����
    // While���� �ݺ�Ƚ���� ��Ȯ���� ������


    // do while��

    int num = 0;

    void Start()
    {
        do // �ݺ��� ����
        {
            num++; // num�� ����
            print(num); // num�� ���
        } while (num < 10); // num���� 10�� �Ǳ� ������ ����
    }
 
    // 1ȸ���� ���� ������ ���� Ȯ��


    // foreach��
    // ����� ������ �ɰ��ִ� �ݺ���

    string text = "�����ٶ󸶹ٻ�";

    void Start()
    {
        foreach(char ab in text) 
        {
            print(ab);
        }
    }
    */
}

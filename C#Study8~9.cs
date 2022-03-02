using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Part 8 �迭
    /*
    int[] exp = { 50, 100, 150, 200, 250, 300 }; // int�� �迭�� exp ����, �迭 ���� 50, 100, 150, 200, 250, 300�� ����

    private void Start()
    {
       
        // print(exp[1]); C#�� ù��° �迭 index���� 0���� �����ϱ� ������ ��°��� 100�� ����

        exp[5] = 500; // �迭�� ������ ���� �ٲܼ������� �迭�� ũ��� �ٲܼ����� ex) exp[6] = 100; ���� ���� �߰��Ҽ�����

       for(int i = 0; i < 5; i++) // �ݺ��� (int�� ���� i�� 5���ɶ����� ����)
        {
            print(exp[i]); // (exp �迭�� index������ i�� �־� ���)
        }

       for(int i = 0; i < exp.Length; i++) // (���������� int�� ���� i�� 0���� �����ؼ� exp�迭�� ��������ŭ ����)
        {
            print(exp[i]);
        }
   

        // 1���� �迭
        int[] exp = { 50, 100, 150, 200, 250, 300 }; // int�� �迭 exp ���� 6���� index�� ����

        int[] array = new int[10]; // int�� �迭 array�� ũ�� 10 ����

        // 2���� �迭
        int[,] array2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } }; // int���̰� 2���� �迭�� array2 ����

        // 3���� �迭
        int[,,] array3 = { { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 }, { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } } };

        void Start()
        {
            // array2 = new int[10];  array2�迭 ũ�� 10 ����
            // array2 = new int[exp.Length]; array2 �迭�� ũ�⸦ exp �迭�� ���̿� ������ ����

            print(array2[1, 3]); // �ι�° �迭�� 3��° index = 40 

            print(array2[0, 1]); // ù��° �迭�� 2��° index = 2

            print(array3[1, 1, 2]); // �ι�° �迭�� �ι�°�迭�� 3��° index = 30

            print(array3[0, 0, 3]); // ù��° �迭�� ù��°�迭�� 4��° index = 4
        }
    }
        */

    // Part 9 �÷���

    int[] exp = new int[5] { 1, 2, 3, 4, 5 }; // int�� �迭 exp�� ũ��� index�� ����

    ArrayList arrayList = new ArrayList(); // Class ArrayList ��� ����

    void Start()
    {
        arrayList.Add(1); // ArrayListŬ���� ������ Add�Լ� ���� (�Լ� = �޼ҵ�)
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add("�����ٶ�");
        arrayList.Add(4.5);

        // arrayList.RemoveAt(3);  �ε��� �ϳ��� ����

        // arrayList.RemoveRange(1, 3) �ε����� ������ �����ؼ� ����

        // print(arrayList.Contains("�����ٶ�")); Ư�� ���Ұ� �ִ��� ������ üũ

        for (int i = 0; i < arrayList.Count; i++) // �ݺ��� (int�� i�� 0���� �����ؼ� arrayList�� ������ŭ ����)
        {
            print(arrayList[i]); // ArrayList�� Length�� �ƴ϶� Count���
        }

        // List�� ArrayList�� ������ List�� �ݵ�� Ư���ڷ����� ���� ���� �߰�����
    }

}

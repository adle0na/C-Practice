#include <iostream>
#include <string>
#include <fstream>
using namespace std;

/* 별그리기 C++ 별트리 찍기 15강
int main() 
{
	for (int i = 0; i < 5; i++) { //한줄씩 내려주는 반복문
		for (int j = 0; j < i + 1; j++) { //한칸씩 늘려주는 반복문
			cout << "*";
		}
		cout << "" << endl;
	}
	for (int k = 0; k < 5; k++) {
		for (int y = 0; y < k + 1; y++) {
			cout << " ";
		}
		cout << "*" << endl;
	}
	return 0;
}
*/

/* 구구단 입력받아서 출력 C++ for문을 활용하여 구구단 만들기 16강
int main()
{
	int a;
	cout << "구구단 몇단을 볼까요?\n";
	cin >> a;
	cout << a << "단을 입력하셨습니다. \n";
	for (int i = 1; i < 10; i++) {
		cout << a << "*" << i << "=" << a * i << endl;
	}
	return 0;
}
*/

/* array 1 17 18강
int main()
{
	int b[5] = { 1,2,3,4 };
	char c[3] = { 'k', 'i', 'm' };

	for (int i = 0; i < 4; i++) {
		cout << b[i] << endl;
	}
	for (int i = 0; i < 3; i++) {
		cout << c[i] << endl;
	}

	return 0;
}
*/
/* 구조체 강의 21강
struct Me {
	int age = 28;
	int height = 173;
	int weight = 62;
	string name = "ADLeona";
};

struct Average {
	int age = 27;
	int height = 171;
	int weight = 65;
};

struct Robot {
	int year;
	int height;
	int weight;
};

int main()
{
	{
		Me h;
		cout << "이름 : " << h.name << endl;
		cout << "나이 : " << h.age << endl;
		cout << "키 : " << h.height << endl;
		cout << "체중 : " << h.weight << endl;
	}

	{
		cout << "\n다음은 평균값입니다. \n";
		Average h;
		cout << "평균 나이 : " << h.age << endl;
		cout << "평균 키 : " << h.height << endl;
		cout << "평균 체중 : " << h.weight << endl;

	}

	{
		Robot h(1995, 300, 120);

		cout << h.year << endl;
		cout << h.height << endl;
		cout << h.weight << endl;

		return 0;
	}
}
*/
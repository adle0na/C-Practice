#include <iostream>
#include <string>
#include <fstream>
using namespace std;

/* 구조체 추가자료
struct human {
	int age;
	int weight;
	string name;
};

void changeInfo(human *ptr, int a, int w, string n) {
	ptr->age = a;
	ptr->weight = w;
	ptr->name = n;
}

int main()
{
	human h;

	changeInfo(&h, 30, 60, "ADLeona");

	cout << h.name << "," << h.age << "," << h.weight << endl;

	changeInfo(&h, 40, 70, "APLeona");

	cout << h.name << "," << h.age << "," << h.weight << endl;

	changeInfo(&h, 50, 90, "ASLeona");

	cout << h.name << "," << h.age << "," << h.weight << endl;

	return 0;
}
*/

/* 함수 사용1 22강
int testFuc(int a) {
	cout << "testFunc" << a << endl;
	return 0;
}

void testVoid() {
	cout << "testVoid" << endl;
}

int main()
{
	testFuc(10);
	testVoid();

	return 0;
}
*/

/* 함수를 이용한 계산기 23강
int sum(int a, int b) {
	return a + b;
}
int cha(int a, int b) {
	return a - b;
}
int main()
{
	int A = 0;
	int B = 0;

	cin >> A;
	cin >> B;
	cout << A << "+" << B << "=" << sum(A, B) << endl;
	cout << A << "-" << B << "=" << cha(A, B) << endl;

	return 0;
}
*/

/* 홀짝 판별기 24강
bool isEvenNumber(int a) {
	bool isEven;

	if (a % 2 == 0) {
		isEven = true;
	}
	else
	{
		isEven = false;
	}
	return isEven;
}

int main() {

	int num = 0;
	cin >> num;
	if (isEvenNumber(num)) {
		cout << "짝" << endl;
	}
	else {
		cout << "홀" << endl;
	}

	return 0;
}
*/

/* 매크로, 라인함수 25강
#define print_(a) cout << a << endl;
// 매크로는 오버헤드 발생없이 문장 자체를 대체해줌
inline void print3(string c) {
	cout << c << endl;
}
// C++에서는 inline이라는 함수를 사용함
void print2(string b) {
	cout << b << endl;
}
// 함수는 실행 후 돌아갈 주소 저장, 오버헤드란 복잡한 과정을 거침

int main() {
	print_("hi !!");
	print2("Hello !!");
	print3("OHayo !!");

	return 0;
}
*/
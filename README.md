//Day1 2022 01 13
#include <iostream>
#include <string>
using namespace std;

int main()
{
	string id;
	string pw;
	cout << "Enter your ID\n" && cin >> id;
//문자에 ""쓰는 방법 기억해둘것
		cout << "Hello \"" << id << "\" Enter your PW\n" && (cin >> pw);
		if (pw == "1111") {
			cout << "Well come!! \"" << id << "\"";
		}
		else if (pw != "1111") {
			cout << "Wrong PassWord !!" << endl;
		}
		return 0;
	}

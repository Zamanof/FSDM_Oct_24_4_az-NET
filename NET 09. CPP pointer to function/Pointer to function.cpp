#include<iostream>
#include<vector>

using namespace std;

bool isOdd(int value) {
	return value % 2 != 0;
}
bool isEven(int value) {
	return value % 2 == 0;
}


vector<int> filter(vector<int> vec, bool (*pred)(int)) {
	vector<int> tmp;
	for (size_t i = 0; i < vec.size(); i++)
	{
		if (pred(vec[i]))  tmp.push_back(vec[i]);
	}
	return tmp;
}


int main() {
	vector<int> vec{ 25, 9, 2, -1, 336, 78, 77 };
	auto odd = filter(vec, [](int a) {return a %3 == 0; });
	for (size_t i = 0; i < odd.size(); i++)
	{
		cout << odd[i] << ' ';
	}
	cout << endl;
	// pointer to function
	// bool (*pred)(int) = isOdd;

}
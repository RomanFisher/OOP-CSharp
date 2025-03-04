﻿// ООП_7.2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>;
#include <map>;
#include <algorithm>
#include <list>
using namespace std;

class Person
{
public:
	char name[20];
	int age;
	char pol[20];
public:
	Person() :age(0)
	{
	}

	Person(int old) : age(old)
	{
	}

	Person(const Person&)
	{
	};


	~Person(void)
	{
		cout << "Vuklukano destruktor " << endl;
	};

	char* getName()
	{
		return name;
	};

	int getAge()
	{
		return age;
	};



	void setAge(int old)
	{
		age = old;
	};

	void printPerson()
	{
		cout << "Name:" << name << "\t age:" << age << "\t pol:" << pol << endl;
	}

	void setPerson()
	{
		cout << "Name:";
		cin >> name;
		cout << "age:";
		cin >> age;
		cout << " pol:";
		cin >> pol;
	}
};
int main()
{
	list<Person> MyList;

	int n;
	Person a;
	cin >> n;
	for (int i = 0; i < n; i++) {
		a.setPerson();
		MyList.push_back(a);
	}
	for(Person n : MyList)
	{
		cout << "\n";
		n.printPerson();
		cout << "\n";
	}
	system("pause");
	return 0;
}


// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.

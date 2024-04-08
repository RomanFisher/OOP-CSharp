// ООП_7.1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <map>
#include <algorithm>
#include <Windows.h>
#include <fstream>
using namespace std;
int main()
{
    fstream fs;
    string path = "myFile.bin";
    fs.open(path, ios::out | ios::binary);
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    map <int, long> MyMap;
    cout << "Введіть кількість пар : ";
    int n, k,p;
    cin >> n;
    for(int i = 0; i<n; i++) MyMap.emplace(i, rand());    
    for (int i = 0; i < n; i++) cout << "№" <<i+1 <<"\t"<< MyMap[i]<<"\n";
    if (fs.is_open())
    {
        for (int i = 0; i < n; i++) { fs.write((char*)&MyMap, sizeof(MyMap)); }
    }
    else cout << "\nФайл не відкрито\n";
    fs.close();
    fs.open(path, ios::in | ios::binary);
    map <int, long> MyMp;
   
    while (fs.eof())
    {
        fs.read((char*)&MyMp, sizeof(MyMap));
    }
    fs.close();
    cout << "\nПрочитано з файла : \n";
    for(int n = 0; n < MyMp.size() ; n++)cout << "№" << n + 1 << "\t" << MyMp[n] << "\n";
    bool t = true;
    while (t)
    {
        cout << "\n0 -> Дальше \n";
        cout << "Введіть номер бажаного елемента  : ";
        cin >> k;
        auto itr = MyMap.find(k-1);
            if (itr != MyMap.end())
            {
                cout << itr->second << "\n";
            }
            else cout << "\nЕлемент не знайдений!!!!!!!!!!\n ";
            if (k == 0)t = false;
    }
    MyMap[2] = 0;
    MyMap[0] = 0;
    cout << "\nЗамінено 1 і 3 елементи на 0\n ";
    for (int i = 0; i < n; i++) cout <<"№" << i + 1 << "\t" << MyMap[i] << "\n";
    t = true;
    while (t)
    {
        cout << "\n0 -> Дальше \n";
        cout << "Введіть номер бажаного елемента  : ";
        cin >> k;
        auto itr = MyMap.find(k - 1);
        if (itr != MyMap.end())
        {
            cout << itr->second << "\n";
        }
        else cout << "\nЕлемент не знайдений!!!!!!!!!!\n ";
        if (k == 0)t = false;
    }
    for (int i = 0; i < n; i++) cout << "№" << i + 1 << "\t" << MyMap[i] << "\n";
    cout << "\nВведіть номер елемента який потрібно видалити\n ";
    cin >> p;
    if (p - 1 < n)
    {
        MyMap.erase(p - 1);
        for (int i = 0; i < n - 1; i++) cout << "№" << i + 1 << "\t" << MyMap[i] << "\n";
    }
    else cout << "\nЕлемент не доступний\n";
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

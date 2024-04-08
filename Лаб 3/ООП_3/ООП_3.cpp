// ООП_3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <string>
#include <windows.h>
using namespace std;
class Tovar
{
    public:
     virtual void showTovar() = 0;
     virtual void addTovar() = 0;
     virtual void show(int k) = 0;
};

class Igrashka : public Tovar
{
public:
    string  name;
    int price;
    string creator;
    string material;
    int yearInChildren;

public:
  
    void showTovar() override
    {
        cout << "Назва іграшки : " << name<<"\n";
        cout << "Ціна : " << price << "\n";
        cout << "Виробник : " << creator << "\n";
        cout << "Матеріал : " << material << "\n";
        cout << "Вікові обмеження : +" << yearInChildren << "\n";
        cout << "\n_________________________\n";
    }
    void addTovar() override
    {
        cout << "Назва іграшки : ";
        getline(cin,name);
        cout << "Ціна : ";
        cin>> price;
        cin.ignore();
        cout << "Виробник : ";
        getline(cin, creator);
        cout << "Матеріал : ";
        getline(cin, material);
        cout << "Вікові обмеження : ";
        cin>>yearInChildren;
        cin.ignore();
        cout << "\n_________________________\n";

    }
    void show(int k)
    {
        if (k == 1)
        {
            this->showTovar();
        }
    }
};

class Book : public Tovar
{
private:
    string  name;
    int price;
    string avtor;
    string vudav;
    int yearInChildren;
public:
   
    void showTovar() override
    {
        cout << "Назва книжки : " << name << "\n";
        cout << "Ціна : " << price << "\n";
        cout << "Автор : " << avtor << "\n";
        cout << "Видавництво : " << vudav << "\n";
        cout << "Вікові обмеження : +" << yearInChildren << "\n";
        cout << "\n_________________________\n";
  
    }
    void addTovar() override
    {
        cout << "Назва книжки : ";
        getline(cin, name);
        cout << "Ціна : ";
        cin >> price;
        cin.ignore();
        cout << "Автор : ";
        getline(cin, avtor);
        cout << "Видавництво : ";
        getline(cin, vudav);
        cout << "Вікові обмеження : ";
        cin >> yearInChildren;
        cin.ignore();
        cout << "\n_________________________\n";
      
    }
    void show(int k)
    {
        if (k == 2)
        {
            this->showTovar();
        }
    }
};

class SportInvent : public Tovar
{
private:
    string  name;
    int price;
    string creator;
    int yearInChildren;
public:
   
    void showTovar() override
    {
        cout << "Назва спорт-інвентаря : " << name << "\n";
        cout << "Ціна : " << price << "\n";
        cout << "Виробник : " << creator << "\n";
        cout << "Вікові обмеження : +" << yearInChildren << "\n";
        cout << "\n_________________________\n";
    }
    void addTovar() override
    {
        cout << "Назва спорт-інвентаря : ";
        getline(cin, name);
        cout << "Ціна : ";
        cin >> price;
        cin.ignore();
        cout << "Виробник : ";
        getline(cin, creator);
        cout << "Вікові обмеження : ";
        cin >> yearInChildren;
        cin.ignore();
        cout << "\n_________________________\n";
    
    }
    void show(int k)
    {
        if (k == 3)
        {
            this->showTovar();
        }
    }
};

void menu()
{
 cout << "Введіть кількість товару : ";
    int a,c;
    cin >> a;
    Tovar** arr = new Tovar* [a];
    for(int i = 0; i < a; i++)
    {
        po4:
        cout << "Вкажіть тип товару: \n 1 - іграшка\n 2 - книжка\n 3 - спорт-інвентар\n";
        cin >> c;
        cin.ignore();
        switch (c)
        {
         case 1:
         {
             arr[i] = new Igrashka();
             arr[i]->addTovar();
             break;
         }
         case 2:
         {
             arr[i] = new Book();
             arr[i]->addTovar();
             break;
         }
         case 3:
         {
             arr[i] = new SportInvent();
             arr[i]->addTovar();
             break;
         }
         default:
         {
             cout << "ПОМИЛКА!!! \n Зробіть правильний вибір\n";
             goto po4;
         }
        }
    }

    for (int i = 0; i < a; i++)
    {
        arr[i]->showTovar();
    }
    bool t = true;
    while (t)
    {
    cout << "Виберіть тип який потрібно вивести\n 1 - іграшки\n 2 - книжки\n 3 - спорт-інвентар \n 0 - вихід\n ";
        int k;
        cin >> k;
        cin.ignore();
        for (int i = 0; i < a; i++)
        {
            arr[i]->show(k);
        }
        if (k == 0)t = false;
    }
    

    delete[] arr;
}
int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    menu();

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

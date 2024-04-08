// ООП_3.0.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

class Vuprobuvannya
{
   
   public:
        string day;
        string months;
        int mark;
   Vuprobuvannya()
    {
        cout<<"Vyzvano konstruktor Vuprobuvannya\n";
    }
};
class Isput : public Vuprobuvannya
{
    public :
        string type;
    Isput()
    {
        cout<<"Vyzvano konstruktor Isput\n";
    }
};

class Zalik : Vuprobuvannya, Isput
{
    public:
     Zalik()
    {
        cout<<"Vyzvano konstruktor Zalik\n";
    }
};

class VupusknuyZalik : Zalik
{
public:
    VupusknuyZalik()
    {
        cout << "Vyzvano konstruktor  VupusknuyZalik\n";
    }
};
int main(){

    Zalik a;
    cout << "\n--------------------------\n";
    VupusknuyZalik v;
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

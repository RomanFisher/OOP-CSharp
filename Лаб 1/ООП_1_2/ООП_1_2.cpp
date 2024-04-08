// ООП_1_2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "iostream"
#include <cstdlib>
#include <ctime>
using namespace std;

class Product
{
   public:
    int n,m;
    double** DoubleArray;
    
    operator bool() 
    {
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (DoubleArray[i][j] > DoubleArray[i][j + 1])k++;
            }
            cout << "\n";
        }
        if ( k != 0) return 1;
        else return 0;
    }


    Product() 
    { 
        cout << "Vizvano konstructor bez parametriv " << endl; 

    }//конструктор без параметра
    Product(int a, int b) 
    { 
        n = a;
        m = b;
        srand(time(NULL));
        cout << "Vizvano konstructor z parametrami " << endl;
        DoubleArray = new double* [n];
        for (int i = 0; i < n; i++)
        {
            DoubleArray[i] = new double[m];
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                DoubleArray[i][j]=rand();
            }
            cout << "\n";
        }
    } //конструктор з параметром
    Product(Product& copy) // конструктор копіювання
    {
        cout << "Vizvano konstructor kopirait " << endl;
    }
    ~Product()
    { 
        cout << "Vizvano destruktor "<< endl; 
        for (int i = 0; i < m ; i++)
        {
            delete[] DoubleArray[i]; //Видалення підмасивів
        }
        delete[] DoubleArray;
    }// деструктор

    void CinMass()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                cout << "Element " << i << " " << j<<" = ";
                cin>>DoubleArray[i][j];
            }
            cout << "\n";
        }
        cout << "\n";
    }
    void Show()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                cout << DoubleArray[i][j]<<"\t";
            }
            cout << "\n";
        }
        cout << "\n";
    }

    void SortStolb()
    {
        int x = 0;
        for (int k = 0; k < n; k++)
        {
            for (int i = m - 1; i > x; i--)
            {
                for (int j = m - 1; j > x; j--) {
                    if (DoubleArray[k][j] < DoubleArray[k][j - 1]) {
                        double tmp = DoubleArray[k][j];
                        DoubleArray[k][j] = DoubleArray[k][j - 1];
                        DoubleArray[k][j - 1] = tmp;
                        cout << "elem " << j << "swap elem " << j + 1 << "\n";
                    }
                }
                x++;
            }
        }
        cout << "\n";
    }

    void DobutokScal(int sc)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                DoubleArray[i][j] *= sc;
            }
        }
        cout << "\n";
    }

    void KlElem()
    {
        cout <<"Kl. elem = "<< n * m<<"\n";
    }

    void Menu()
    {
        bool t = false;
        int d;
        while (t != true)
        {
            cout << "1 - vvod arr\n";
            cout << "2 - vyvid arr\n";
            cout << "3 - domnozhennya na scalyar\n";
            cout << "4 - kl elem arr\n";
            cout << "5 - ++\n";
            cout << "6 - *\n";
            cout << "0 - exit\n";
            cin >> d;
            switch (d)
            {
            case 1: {CinMass();  break; }
            case 2: {Show(); break; }
            case 3: {
                cout << "Vvedit scalyar \n";
                int sc;
                cin >> sc;
                DobutokScal(sc);
                break; }
            case 4: {KlElem(); break; }
            case 5: { ++*this; break; }
            case 6:
            { 
              
               
               break; }
            case 0: {t = true; break; }
            default: 
            {
                cout << "\n ERROR - zrobit vybir\n";
            }
            }

        }
    }
    Product& operator++()
    {
        for (int i = 0; i < m ;i++)
        {
            for (int j = 0; j < n; j++)
            {
                this->DoubleArray[j][i]+=1;
            }
        }
        return *this;
    }
    Product& operator--()
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                this->DoubleArray[j][i]--;
            }
        }
        return *this;
    }
    
   
};
    
 Product operator *(Product a1, Product a2)
    {
     Product a(a1.n,a1.m);
     if (a1.m == a2.m && a1.n == a2.n)
     {
         for (int i = 0; i < a1.n; i++)
         {
             for (int j = 0; j < a1.m; j++)
             {
                a.DoubleArray[i][j]= a1.DoubleArray[i][j] * a2.DoubleArray[i][j];
             }
         }
     }
     return a;
    }

int main()
{
    Product a1(3,2);
    Product a(3,2); //З умовою  
    Product b; // без умови
    Product c(a); // к,опіювання
    //a.Menu();
    bool t = false;
    while (t != true)
    {
        cout << "1 - vuvid \n";
        cout << "2 - ++\n";
        cout << "3 - --\n";
        cout << "4 - *\n";
        cout << "5 - vvid \n";

        cout << "0 - exit\n";
        int d;
        cin >> d;
        switch (d)
        {
        case 5:
        {
            a1.CinMass();
            a.CinMass();
            break;
        }
        case 4:
        {
            a1.Show();
            cout << "*******************\n";
            a.Show();
            Product b(3,2);
            b = a * a1;
            b.Show();
            break;
        }
        case 1:
        {
            a.Show(); break;
        }
        case 2:
        {
            ++a;
            a.Show(); break;
        }
        case 3:
        {
            --a;
            a.Show(); break;
        }
        case 0:
        {
           t = true;
        }
        default:
        {
            cout << "\n ERROR - zrobit vybir\n";
        }
        }

    }
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

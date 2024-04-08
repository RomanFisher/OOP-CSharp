using System;
using System.Collections.Generic;

namespace ООП_2._1
{
    class Program
    {
        class Product
        {
            public int n;
            public int m;
            public double[,] DoubleArray;
            public Product() { }

            Random rand = new Random();
            public Product(int a, int k)
            {
                n = a;
                m = k;
                DoubleArray = new double[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        DoubleArray[i, j] = rand.Next(100);
                    }
                }
            }
              public static Product operator ++ (Product a)
                {
                        for (int i = 0; i < a.n; i++)
                    {
                        for (int j = 0; j < a.m; j++)
                        {
                            a.DoubleArray[i, j] +=1;
                        }
                    }
                 return a;
                }
            public static bool operator !(Product a)
            {
                int k = 0;
                for (int i = 0; i < a.n; i++)
                {
                    for (int j = 0; j < a.m-1; j++)
                    {
                        if (a.DoubleArray[i,j] > a.DoubleArray[i,j + 1]) k++;
                    }
                }
                if (k != 0) return true;
                else return false;

            }
            public static Product operator *(Product a, Product b)

            {
                 Product result = new Product(a.n, a.m);
                if (a.n == b.n && a.m == b.m)
                {

                    for (int i = 0; i < a.n; i++)
                    {
                        for (int j = 0; j < a.m; j++)
                        {
                            result.DoubleArray[i, j] = a.DoubleArray[i, j] * b.DoubleArray[i, j];
                        }
                    }
                }
                return result;
            }
            public static Product operator --(Product a)
            {
                for (int i = 0; i < a.n; i++)
                {
                    for (int j = 0; j < a.m; j++)
                    {
                        a.DoubleArray[i, j] -= 1;
                    }
                }
                return a;
            }
            public Product(Product a)
            {
                n = a.n;
                m = a.m;
                DoubleArray = a.DoubleArray;
            }

            ~Product()
            {
                Console.WriteLine("Vyzvano destructor");
            }

            public void CinMass()
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write( "Element " + i + " "+ j + " = ");
                        DoubleArray[i,j] = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }
            public void Show()
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(Convert.ToString(DoubleArray[i, j]));
                        Console.Write("\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }

            public void Show(int k)
            {
                List<double> list = new List<double>();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        list.Add(DoubleArray[i, j]);
                    }
                }
                k = 0;
                int z = 1;
                for (int i = 0; i < n; i++)
                {
                    if (z < n) z++;
                    else break;
                    for (int j = 0; j < z; j++)
                    {
                        Console.Write(Convert.ToString(list));
                        Console.Write("\t");
                    }
                    Console.Write("\n");
                }

            }
            public void DobutokScal(int sc)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        DoubleArray[i,j] *= sc;
                    }
                }
                Console.WriteLine("\n");
            }

            public void KlElem()
            {
                Console.WriteLine("Kl. elem = " + n * m);
            }

            public void Menu()
            {
                bool t = false;
                int d;
                while (t != true)
                {
                    Console.WriteLine("1 - vvod arr");
                    Console.WriteLine("2 - vyvid arr");
                    Console.WriteLine("3 - domnozhennya na scalyar");
                    Console.WriteLine("4 - kl elem arr");
                    Console.WriteLine("5 - ++");
                    Console.WriteLine("6 - --");
                    Console.WriteLine("0 - exit");
                    d = Convert.ToInt32(Console.ReadLine());
                    if(d==1){ CinMass();}
                    else if(d==2){ Show();}
                    else if(d==3)
                            {
                                Console.WriteLine("Vvedit scalyar \n");
                                int sc;
                                sc = Convert.ToInt32(Console.ReadLine());
                                DobutokScal(sc);
                            }
                    else if(d==4) { KlElem();}
                    else if(d==0) { t = true; }
                    else
                        {
                                Console.WriteLine("\n ERROR - zrobit vybir\n");
                        }
                    }

                }
            

            }

        public static void Menu()
        {
            Product a = new Product(2, 3);
            bool t = false;
            int d;
            while (t != true)
            {
                Console.WriteLine("1 - vvod arr");
                Console.WriteLine("2 - vyvid arr");
                Console.WriteLine("3 - domnozhennya na scalyar");
                Console.WriteLine("4 - kl elem arr");
                Console.WriteLine("5 - ++");
                Console.WriteLine("6 - --");
                Console.WriteLine("7 - *");
                Console.WriteLine("8 - perev na vporyadkovanist");
                Console.WriteLine("0 - exit");
                d = Convert.ToInt32(Console.ReadLine());
                if (d == 1) { a.CinMass(); }
                else if (d == 2) { a.Show(); }
                else if (d == 3)
                {
                    Console.WriteLine("Vvedit scalyar \n");
                    int sc;
                    sc = Convert.ToInt32(Console.ReadLine());
                    a.DobutokScal(sc);
                }
                else if (d == 4) { a.KlElem(); }
                else if (d == 5) { a++; Console.WriteLine("\n"); a.Show(); }
                else if (d == 6) { a--; Console.WriteLine("\n"); a.Show(); }
                else if (d == 7)
                { 
                    a.Show(); 
                    Console.WriteLine("____________*___________\n");
                    Product b = new Product(2, 3);
                    b.Show();
                    a = a*b;
                    Console.WriteLine("             ||         \n");
                    a.Show();
                }
                else if (d == 8) 
                {
                    if(!a)
                    {
                        Console.WriteLine("\nNe vporyad\n");
                    } 
                    else Console.WriteLine("\nVporyad\n");
                }
                else if (d == 9) { a.Show(0); }
                else if (d == 0) { t = true; }
                else
                {
                    Console.WriteLine("\n ERROR - zrobit vybir\n");
                }
            

        }
    }
        static void Main(string[] args)
        {
        
            Menu();
        }
    }
}

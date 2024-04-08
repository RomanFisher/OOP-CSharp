using System;
using System.Collections.Generic;

namespace ООП_3._1
{
    class Program
    {
        abstract class Tovar
        {
            public string name;
            public int price;
            public int yearInChildren;
            public abstract void showTovar();
            public abstract void addTovar();
            public abstract void show(int k);
        }
        class  Igrashka : Tovar
        {
            public string creator;
            public string material;
            public override void showTovar()
            {
                Console.WriteLine("Назва іграшки : " + name);
                Console.WriteLine("Ціна : " + price);
                Console.WriteLine("Виробник : " + creator);
                Console.WriteLine("Матеріал : " + material);
                Console.WriteLine("Вікові обмеження : +" + yearInChildren);
                Console.WriteLine("\n_________________________\n");
            }

            public override void addTovar()
            { 
                Console.Write("Назва іграшки : ");
                name=Console.ReadLine();
                Console.Write("Ціна : ");
                price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Виробник : ");
                creator = Console.ReadLine();
                Console.Write("Матеріал : ");
                material = Console.ReadLine();
                Console.Write("Вікові обмеження : ");
                yearInChildren = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n_________________________\n");
            }
            public override void show(int k)
            {
                if (k == 1)
                {
                    showTovar();
                }
            }
        }

        class Book : Tovar
        {
            public string avtor;
            public string vudav;
            public override void showTovar()
            {
                Console.WriteLine("Назва книжки : " + name);
                Console.WriteLine("Ціна : " + price);
                Console.WriteLine("Автор : " + avtor);
                Console.WriteLine("Видавництво : " + vudav);
                Console.WriteLine("Вікові обмеження : +" + yearInChildren);
                Console.WriteLine("\n_________________________\n");
            }

            public override void addTovar()
            {
                Console.Write("Назва книжки : ");
                name = Console.ReadLine();
                Console.Write("Ціна : ");
                price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Автор : ");
                avtor = Console.ReadLine();
                Console.Write("Видавник : ");
                vudav = Console.ReadLine();
                Console.Write("Вікові обмеження : ");
                yearInChildren = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n_________________________\n");
            }
            public override void show(int k)
            {
                if (k == 2)
                {
                    showTovar();
                }
            }
        }

        class SportInvent : Tovar
        {
            public string creator;
            public override void showTovar()
            {
                Console.WriteLine("Назва спорт-івентаря : " + name);
                Console.WriteLine("Ціна : " + price);
                Console.WriteLine("Виробник : " + creator);
                Console.WriteLine("Вікові обмеження : +" + yearInChildren);
                Console.WriteLine("\n_________________________\n");
            }

            public override void addTovar()
            {
                Console.Write("Назва спорт-інвентаря : ");
                name = Console.ReadLine();
                Console.Write("Ціна : ");
                price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Виробник : ");
                creator = Console.ReadLine();
                Console.Write("Вікові обмеження : ");
                yearInChildren = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n_________________________\n");
            }
            public override void show(int k)
            {
                if (k == 3)
                {
                    showTovar();
                }
            }
        }

        public static void menu()
        {
            Console.Write("Введіть кількість товару : ");
                int a, c;
                a = Convert.ToInt32(Console.ReadLine());
                Tovar[] arr = new Tovar [a];
                for (int i = 0; i < a; i++)
                {
                po4:
                    Console.Write("Вкажіть тип товару: \n 1 - іграшка\n 2 - книжка\n 3 - спорт-інвентар\n");
                    c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            {
                                arr[i] = new Igrashka();
                                arr[i].addTovar();
                                break;
                            }
                        case 2:
                            {
                                arr[i] = new Book();
                                arr[i].addTovar();
                                break;
                            }
                        case 3:
                            {
                                arr[i] = new SportInvent();
                                arr[i].addTovar();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine( "ПОМИЛКА!!! \n Зробіть правильний вибір\n");
                                goto po4;
                            }
                    }
                }

                for (int i = 0; i < a; i++)
                {
                    arr[i].showTovar();
                }
                bool t = true;
                while (t)
                {
                    Console.WriteLine("Виберіть тип який потрібно вивести\n 1 - іграшки\n 2 - книжки\n 3 - спорт-інвентар \n 0 - вихід\n ");
                    int k;
                    k = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < a; i++)
                    {
                        arr[i].show(k);
                    }
                    if (k == 0) t = false;
                }
        } 



        
        static void Main(string[] args)
        {
            menu();  
        }
    }
}

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
        class Storinka
        {
            public int number;
        };
        class Nadiinist
        {
            public string nad;
        };
        class Igrashka : Tovar
        {
            public string creator;
            public string material;
            public Nadiinist nadiinist;
            public int[] prr = new int[1] { 1221 };

            public int this[int index]
            {
                get { return this[index]; }
                set
                {
                    if (index < prr.Length)
                        prr[index] = value;
                }
            }
            public Igrashka()
            {
                nadiinist = new Nadiinist();
            }
            public override void showTovar()
            {
                Console.WriteLine("Назва іграшки : " + name);
                Console.WriteLine("Ціна : " + price);
                Console.WriteLine("Виробник : " + creator);
                Console.WriteLine("Матеріал : " + material);
                Console.WriteLine("Вікові обмеження : +" + yearInChildren);
                Console.WriteLine("Надійність : " + nadiinist.nad);
                Console.WriteLine("Провірочне значення індексації : " + prr[0]);
                Console.WriteLine("\n_________________________\n");
            }

            public override void addTovar()
            {
                Console.Write("Назва іграшки : ");
                name = Console.ReadLine();
                Console.Write("Ціна : ");
                price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Виробник : ");
                creator = Console.ReadLine();
                Console.Write("Матеріал : ");
                material = Console.ReadLine();
                Console.Write("Вікові обмеження : ");
                yearInChildren = Convert.ToInt32(Console.ReadLine());
                Console.Write("Надійність : ");
                nadiinist.nad = Convert.ToString(Console.ReadLine());
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
            public Storinka storinka;
           
            public Book(Storinka st)
            {
                storinka = st;
            }
            public override void showTovar()
            {
                Console.WriteLine("Назва книжки : " + name);
                Console.WriteLine("Ціна : " + price);
                Console.WriteLine("Автор : " + avtor);
                Console.WriteLine("Видавництво : " + vudav);
                Console.WriteLine("Вікові обмеження : +" + yearInChildren);
                Console.WriteLine("Кількість сторінок : " + storinka.number.ToString());
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
                    public int[] prr = new int[1] { 1221 };

                    public int this[int index]
                    {
                        get { return this[index]; }
                        set {
                                if(index<prr.Length)
                                prr[index] = value; 
                            }
                    }
            public override void showTovar()
            {
                Console.WriteLine("Назва спорт-івентаря : " + name);
                Console.WriteLine("Ціна : " + price);
                Console.WriteLine("Виробник : " + creator);
                Console.WriteLine("Вікові обмеження : +" + yearInChildren);
                Console.WriteLine("Провірочне значення індексації : " + prr[0]);
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
            Tovar[] arr = new Tovar[a];
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
                            Console.Write("Введіть кількість сторінок в книжці : ");
                            Storinka storinka = new Storinka();
                            storinka.number = Convert.ToInt32(Console.ReadLine());
                            arr[i] = new Book(storinka);
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
                            Console.WriteLine("ПОМИЛКА!!! \n Зробіть правильний вибір\n");
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
            SportInvent invent = new SportInvent();
            invent.addTovar();
            invent[0] = 3;
            invent.showTovar();
            FirstNS.Product product = new FirstNS.Product();
            SecondNS.Product product1 = new SecondNS.Product();
        }
    }   
    namespace FirstNS
    {
        class Product
        {
            public Product()
                {
                Console.WriteLine("Визвано конструктор класу Product з простору імен FirstNS ");
                }
        }
    }

    namespace SecondNS
    {
        class Product
        {
            public Product()
                {
                Console.WriteLine("Визвано конструктор класу Product з простору імен SecondNS ");
                }
        }
    }
}

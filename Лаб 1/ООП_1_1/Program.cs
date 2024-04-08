using System;

namespace ООП_1_1
{
    class MyClass
    {
        
        public string name;
        public int numberHouse;
        public string street;
        
        public MyClass (string nameZ, string streetZ, int numberHouseZ)
        {
            name = nameZ;
            numberHouse = numberHouseZ;
            street = streetZ;
        }
        ~MyClass()
        {
            Console.WriteLine("Done");
        }
        public MyClass()
        {
  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool t = false;
            while (t != true)
            {


                Console.WriteLine("1 - vuvesty gotovyi element");
                Console.WriteLine("2 - zapovnyty element");
                Console.WriteLine("0 - exit");
                int a = Convert.ToInt32(Console.ReadLine());
                MyClass temp = new MyClass();
                MyClass value = new MyClass("Roman", "Gastello", 15);
                if (a == 1)
                {
                    Console.Write("\n");
                    Console.Write(value.name);
                    Console.Write("\t");
                    Console.Write(value.street);
                    Console.Write("\t");
                    Console.Write(value.numberHouse);
                    Console.Write("\n");
                }

                else if (a == 2)
                {
                    Console.Write("\n");
                    Console.WriteLine("Vvedit imya");
                    temp.name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Vvedit vulyciy");
                    temp.street = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Vvedit nomer bud");
                    temp.numberHouse = Convert.ToInt32(Console.ReadLine());
                }
             
                if (a == 0) t = true;

            }
           
        }
    }
}

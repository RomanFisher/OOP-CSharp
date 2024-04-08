using System;

namespace ООП_3._2
{
    class Program
    {
         class Vuprobuvannya
        { 
         public string day;
         public string months;
         public int mark;
           public Vuprobuvannya()
            {
                Console.WriteLine("Vyzvano konstruktor Vuprobuvannya\n");
            }
        };
        class Isput : Vuprobuvannya
        { 
        public  string type;
        public Isput()
        {
            Console.WriteLine("Vyzvano konstruktor Isput\n");
        }
        };
        class Zalik : Vuprobuvannya
        {
            public Zalik()
            {
                Console.WriteLine("Vyzvano konstruktor Zalik\n");
            }
        };

        class VupusknuyZalik : Zalik
        {
             public VupusknuyZalik()
            {
                Console.WriteLine("Vyzvano konstruktor  VupusknuyZalik\n");
            }
        };
        static void Main(string[] args)
        {
            Zalik z = new Zalik();
            Console.WriteLine("\n___________________________\n");
            VupusknuyZalik vupusknuy = new VupusknuyZalik();
        }
    }
}

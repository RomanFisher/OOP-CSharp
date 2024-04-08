using System;

namespace ООП_4._1
{
    class Program
    {
        public interface Ib
        {
            public void Ib_();
        }
        public interface Id1
        {
            public void Id1_();
        }
        private interface Id2
        {
            public void Id2_();
        }
        private interface Id3
        {
            public void Id3_();
        }
        private interface Id4
        {
            public void Id4_();
        }
        public class D1 : Ib
        {
            public void Ib_()
            {
                Console.WriteLine("Клас D1 наслідує інтерфейс B ");
            }
        }
        public class D2 : Ib
        {
            public void Ib_()
            {
                Console.WriteLine("Клас D2 наслідує інтерфейс B");
            }
        }

        public class D3 : D1
        {
            public void Ib_()
            {
                Console.WriteLine("Клас D3 наслідує інтерфейс B та клас D1");
            }
        }

        public class D4 : Ib, Id1,Id2
        {
            public void Ib_()
            {
                Console.WriteLine("Клас D4 наслідує інтерфейс B");
            }
            public void Id1_()
            {
                Console.WriteLine("Клас D4 наслідує інтерфейс D1");
            }
            public void Id2_()
            {
                Console.WriteLine("Клас D4 наслідує інтерфейс D2");
            }
        }
        static void Main(string[] args)
        {
            D3 d3 = new D3();
            d3.Ib_();
            Console.WriteLine("______________________________");
            D4 d4 = new D4();
            d4.Ib_();
            d4.Id1_();
            d4.Id2_();
        }
    }
}

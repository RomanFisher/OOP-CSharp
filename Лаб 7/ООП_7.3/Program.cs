using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace ООП_7._3
{
    [Serializable]
    class Program
    {
        
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            for(int i =0; i<2;i++)
            {
                sd.Add(i + 1,Console.ReadLine());
            }
            
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(SortedDictionary<int, string>));

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, sd);
            }

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                SortedDictionary<int, string> newsd = (SortedDictionary<int, string>)jsonFormatter.ReadObject(fs);


                foreach (KeyValuePair<int, string> item in newsd)
                {
                    Console.WriteLine("Key : {0}, Value : {1}", item.Key, item.Value);
                }
            }

            Console.ReadLine();

        }
    }
}

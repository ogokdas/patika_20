using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> D1 = new Dictionary<int, string>();
            D1.Add(1, "Ömer");
            D1.Add(2, "Miyem");
            D1.Add(3, "Memin");
            D1.Add(4, "Hatice");

            foreach (var item in D1.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(D1[2]);

            Console.WriteLine(D1.Count());
            bool iceriyormu = D1.ContainsKey(5);
            if (iceriyormu)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();


        }
    }
}

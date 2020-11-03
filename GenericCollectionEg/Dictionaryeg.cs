using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionEg
{
    class DictionaryEg
    {
        static void Main()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();

            dt.Add(8, "ab");
            dt.Add(9, "cd");
            dt.Add(10, "bc");
            dt.ContainsKey(9);
            Console.WriteLine("Contains:{0}", dt.ContainsKey(9));
            Console.WriteLine("Count:{0}", dt.Count());
            foreach (KeyValuePair<int, string> k in dt)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }
            Console.Read();

        }
    }
}

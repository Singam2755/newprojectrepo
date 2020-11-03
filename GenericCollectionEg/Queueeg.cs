using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionEg
{
    class Queueeg
    {
        static void Main()

        { 
        Queue<string> q1 = new Queue<string>();
            q1.Enqueue("singam");
            q1.Enqueue("ganesh");
            q1.Enqueue("singampalli");
            foreach (string item in q1)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}

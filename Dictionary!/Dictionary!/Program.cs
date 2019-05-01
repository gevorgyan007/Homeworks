using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first MultiMap.
            var multiMap = new Multimap< bool ,string>();
            multiMap.Add("key1", true);
            multiMap.Add("key1", false);
            multiMap.Add("key2", false);
            
            foreach (string key in multiMap.Keys)
            {
                foreach (bool value in multiMap[key])
                {
                    Console.WriteLine("MULTIMAP: " + key + "=" + value);
                }
            }

            // Create second MultiMap.
            var multiMap2 = new Multimap<string,string>();
            multiMap2.Add("animal", "cat");
            multiMap2.Add("animal", "dog");
            multiMap2.Add("human", "tom");
            multiMap2.Add("human", "tim");
            multiMap2.Add("mineral", "calcium");
            //multiMap2.Remove("mineral", "calcium");

            foreach (string key in multiMap2.Keys)
            {
                foreach (string value in multiMap2[key])
                {
                    Console.WriteLine("MULTIMAP2: " + key + "=" + value);
                }
            }
            Console.ReadKey();
        }
    }
}

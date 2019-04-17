using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RollingDie r = new RollingDie();
            r.OnRollingFoursEvent += () => Console.WriteLine("four"); 
            r.OnRollingSumEvent += () => Console.WriteLine("Sum");
            r.Gen();
             
            
            Console.ReadKey();
        }
    }
}

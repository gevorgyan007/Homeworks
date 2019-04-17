using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class RollingDie
    {
        public delegate void Roll();
        public event Roll OnRollingFoursEvent;
        public event Roll OnRollingSumEvent;

        public void Gen()
        {
           
            
            Random rnd = new Random();
            List<int> roll = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                roll.Add(rnd.Next(1, 7));
                if ((i - 1) > 0 && roll[i - 1] == 4 && roll[i] == 4)
                {
                    if (OnRollingFoursEvent != null)
                    {
                        OnRollingFoursEvent();
                    }
                }
                if (i >= 4 && i < 45 && roll.Skip(i - 4).Take(5).Sum()>=20)
                {
                    if (OnRollingSumEvent != null)
                    {
                        OnRollingSumEvent();
                    }
                }
                 
            }

            foreach (var item  in roll)
            {
                Console.Write(item + " ");
            }
           
        }

    }
            

        }
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8.Interfaces
{
    internal interface IWalkable
    {
        public void walk();
    }
    internal interface IWalk
    {
        public void walk();
    }
    public class robot : IWalk, IWalkable
    {
        void IWalk.walk()
        {
            Console.WriteLine("The robot can walk");
        }

        void IWalkable.walk()
        {
            Console.WriteLine("Robot is walking Differently");
        }
    }

}

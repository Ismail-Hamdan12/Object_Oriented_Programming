using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    interface Movable
    {
        void Move();
    }
    interface Stoppable
    {
        void Stop();
    }
    interface Flying : Movable, Stoppable
    {
        void Fly();
    }
    class Multiple_Interf : Flying
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
        public void Move()
        {
            Console.WriteLine("Moving");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping");
        }
    }
}

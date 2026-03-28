using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    abstract class Data_Hide
    {
        public abstract void sound();
        public void hide()
        {
            Console.WriteLine("Data Hiding Example");
        }
    }
    class Data_Hide_Ex : Data_Hide
    {
        public override void sound()
        {
            Console.WriteLine("Data Hiding Example - Overridden Method");
        }
    }
}

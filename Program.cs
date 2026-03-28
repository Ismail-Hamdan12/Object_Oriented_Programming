using Abstraction_Interface.Abstraction;
using Abstraction_Interface.IInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* SubAbst2 s = new SubAbst2();
            s.Show();
            SubAbst k = new SubAbst();
            k.Show();*/
            Demo d = new Demo();
            d.Show();
            MyClass m = new MyClass();
            m.Show();
        }
    }
}

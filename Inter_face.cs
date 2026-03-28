using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface Drawable
    {
        void draw();
    }
    public class Inter_face : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class Circle : Drawable
    {
     public void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    interface Logger
    {
        void Log(string message);
        void Loginfo(string messages)
        {
         Console.WriteLine($"INFO : {messages}");
        }
    }


    class Default_Inter : Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log message: {message}");
        }
    }

}


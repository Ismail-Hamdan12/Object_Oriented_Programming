using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    class Abstraction_Ex
    {
        private double bal;
        public void Deposit(double amount)
        {
            bal += amount;
        }
        public double GetBalance()
        {
            return bal;
        }
    }
}

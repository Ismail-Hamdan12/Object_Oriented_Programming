using System;
namespace Abstractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction_Ex account = new Abstraction_Ex();
            account.Deposit(1500);
            Console.WriteLine("Current Balance: " + account.GetBalance());
            account.Deposit(2500);
            Console.WriteLine("Current Balance: " + account.GetBalance());

            Console.WriteLine("=============================================");
            Data_Hide_Ex dataHideExample = new Data_Hide_Ex();
            dataHideExample.hide();
            dataHideExample.sound();

            Console.WriteLine("=============================================");
            Drawable d;
            d = new Circle();
            d.draw();
            d = new Inter_face();
            d.draw();

            Console.WriteLine("=============================================");
            Logger logger = new Default_Inter();
            logger.Log("This is a log message.");
            logger.Loginfo("This is an informational message.");

            Console.WriteLine("===============================================");
            Flying f = new Multiple_Interf();
            f.Move();
            f.Fly();
            f.Stop();

        }
    }
}

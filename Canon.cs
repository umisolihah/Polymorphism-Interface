using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Interface
{
    public class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension: 9.5x12 ");
        }
        public void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
}
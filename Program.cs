using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinPipe_ConsoleApp3
{
    internal class Program
    {
        void display()
        {
            Console.WriteLine("Hello Pipeline");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.display();
            Console.ReadLine();
        }
    }
}

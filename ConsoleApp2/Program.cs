using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class Program
    {
        [DllImport("C:\\Users\\User\\source\\repos\\ConsoleApp2\\x64\\Debug\\Dll1.dll")]
        static extern uint fibonacci_index();
        [DllImport("C:\\Users\\User\\source\\repos\\ConsoleApp2\\x64\\Debug\\Dll1.dll")]
        static extern bool fibonacci_next();
        [DllImport("C:\\Users\\User\\source\\repos\\ConsoleApp2\\x64\\Debug\\Dll1.dll")]
        static extern ulong fibonacci_current();
        [DllImport("C:\\Users\\User\\source\\repos\\ConsoleApp2\\x64\\Debug\\Dll1.dll")]
        static extern void fibonacci_init(ulong a, ulong b);
        static void Main(string[] args)
        {
            fibonacci_init(1, 1);

            while (fibonacci_next())
            {
                Console.WriteLine(fibonacci_index() + ": " + fibonacci_current());
                if (fibonacci_index() == 92) break;
            }
            Console.WriteLine((fibonacci_index() + 1) + " Fibonacci sequence values fit in an unsigned 64-bit integer.");
            Console.ReadLine();
        }
    }
}

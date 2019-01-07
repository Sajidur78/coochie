using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Coochie
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 3; i > 0; i--)
            {
                Console.WriteLine($"Crashing in {i}...");
                Thread.Sleep(1000);
            }
            throw new NotImplementedException("Crashing not yet implemented!");
        }
    }
}

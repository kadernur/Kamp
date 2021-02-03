using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<1000)
            {
                i += 5; Console.WriteLine("{0,5}",i);
                if (i / 50 == 0) Console.WriteLine();
            }
            
        }
        
    }
}

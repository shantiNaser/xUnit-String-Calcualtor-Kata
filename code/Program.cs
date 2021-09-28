using System;
using System.Collections;
using System.Linq;


namespace code
{
    

    class Program
    {
        static void Main(string[] args)
        {
           Kata K = new Kata();
           int g = K.AddUsingLinq("//$\n3$2$10000");
           System.Console.WriteLine(g);

        
        }
    }
}

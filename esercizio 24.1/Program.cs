using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esercizio_24._1.Properties;

namespace esercizio_24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato q=new Quadrato();

            Console.WriteLine("inserire lato");
            q.Lato=float.Parse(Console.ReadLine());

            Console.WriteLine("superficie quadrato: {0}", q.Lato * q.Lato);

            Console.ReadLine();
        }
    }
}

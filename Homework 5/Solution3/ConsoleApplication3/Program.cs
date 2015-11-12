using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {


            string text = "a.b.c.d.e.f.g.h.i.j.k.l.m.n.o.p.q.r.s.t.u.v.w.x.y.z";
            PrintStringReverse(text);
        }
        
        private static void PrintStringReverse(string text)
        {
            for (int i = text.Length - 1; i > -1; i--)
            {
                Console.WriteLine(text[i]);
            }
        }


    }
}
        
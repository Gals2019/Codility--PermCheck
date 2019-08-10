using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility__PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Ar = {101,102,103};

            int AnalisisArray(int [] A) {

                Array.Sort(A);


                return (Enumerable.Range(1,A.Length).Except(A).Count()==0)?1:0;

             

            }

            Console.WriteLine(AnalisisArray(Ar));
            Console.ReadLine();

        }
    }
}

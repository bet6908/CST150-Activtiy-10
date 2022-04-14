//Corrected by <Roberto GonzalezRamirez>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST150_Activtiy_10
{
    class Program
    {
        static void Main( string[] args)
        {
            //Here we would need to attach a namespace to pull information from the Set class
            //make some sets
            //Set A = new Set();
            //Set B = new Set();
            CST150_Activtiy_10.Set A = new CST150_Activtiy_10.Set();
            CST150_Activtiy_10.Set B = new CST150_Activtiy_10.Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //disbplay original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
}
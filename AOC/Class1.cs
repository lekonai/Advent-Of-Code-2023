using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC
{
    public class Class1
    {
        static public void whatsUp()
        {
            int[] counting = new int[1];
            counting.Append(2);
            counting.Append(6);
            counting.Append(7);
            for (int i = 0; i < counting.Length; i++)
            {
                Console.WriteLine(counting[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    public static class Helpers
    {
        public static void PrintListofLists<T>(this IList<IList<T>> ls)
        {
            foreach (var item in ls)
            {
                Console.Write('[');
                foreach (var n in item)
                {
                    Console.Write(n);
                    Console.Write(',');
                }
                Console.Write("\b");
                Console.Write("]\n");

            }
        }
    }
}


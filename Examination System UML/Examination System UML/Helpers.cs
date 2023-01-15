using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    public static class Helpers
    {
        public static void PrintList<T>(this IList<T> ls)
        {
            foreach (var item in ls)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}


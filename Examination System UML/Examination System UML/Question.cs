using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    public class Question
    {
        public int Id { get; set; }
        
        public string Statement { get; set; }

        public List<string> Choices { get; set; }

        public int Answer { get; set; }

        public int Type { get; set; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}

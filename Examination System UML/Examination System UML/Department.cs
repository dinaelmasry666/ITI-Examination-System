﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System_UML
{
    public class Department
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int ManagerId { get; set; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}

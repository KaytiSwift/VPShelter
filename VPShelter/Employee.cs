using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    abstract class Employee
    {
        public int EmployeeID
        {
            get; set;
        }

        abstract public void CleanCages();
        abstract public void MethodTwo();
    }
}

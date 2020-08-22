using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    [Serializable]
    class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public Employee(int EmpId, string EmpName)
        {
            this.EmployeeId = EmpId;
            this.EmployeeName = EmpName;
        }
    }
}

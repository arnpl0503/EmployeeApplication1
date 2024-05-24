using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication1
{
    internal interface Iemployee
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }

        void ComputeSalary(int hoursWorked, double ratePerHour);
        double GetSalary();
    }
}

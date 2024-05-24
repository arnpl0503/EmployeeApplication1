using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication1
{
    internal class PartTimeEmployee : IEmployee
    {
        private string firstname;
        private string lastname;
        private string department;
        private string jobtitle;
        private double basicsalary;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string JobTitle
        {
            get { return jobtitle; }
            set { jobtitle = value; }
        }

        public double BasicSalary
        {
            get { return basicsalary; }
            set { basicsalary = value; }
        }

        public PartTimeEmployee(string firstname, string lastname, string department, string job)
        {
            FirstName = firstname;
            LastName = lastname;
            Department = department;
            JobTitle = job;
        }

        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            BasicSalary = hoursWorked * ratePerHour;
        }

        public double GetSalary()
        {
            return BasicSalary;
        }
    }

    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }

        void ComputeSalary(int hoursWorked, double ratePerHour);
        double GetSalary();
    }
}
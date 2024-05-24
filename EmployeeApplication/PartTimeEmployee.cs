using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee:IEmployee
    {
        private string Fname;
        private string Lname;
        private string dept;
        private string job;
        private double basic_salary;


        public string Firstname
        {

            get
            {
                return Fname;
            }
            set
            {
                Fname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return Lname;
            }
            set
            {
                Lname = value;
            }
        }
        public string Department
        {
            get
            {
                return dept;
            }
            set
            {
                dept = value;
            }
        }
        public double basicSalary
        {
            get
            {
                return basic_salary;
            }
            set
            {
                basic_salary = value;
            }
        }
         
        public void computeSalary(int hoursWorked,double ratePerHour)
        {
             basic_salary = hoursWorked * ratePerHour;
        }
        public double getSalary()
        {
            return basic_salary;

        }
        public PartTimeEmployee(string Fname, string Lname,string dept,string job)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.dept = dept;
            this.job = job;

        }
    }
    }

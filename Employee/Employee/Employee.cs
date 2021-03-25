using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgram
{
    class Employee
    {
        private string employeeName;
        private double currentSalary, taxAmount;

        public Employee (string employeeName, double currentSalary)
        {
            this.employeeName = employeeName;
            this.currentSalary = currentSalary;
        }
        //Accessor Methods
        public string getName()
        {
            return this.employeeName;
        }
        public string getSalary()
        {
            return this.currentSalary.ToString("C");
        }
        public double returnSalary()
        {
            return this.currentSalary;
        }
        //Mutator Methods
        public void setName(string employeeName)
        {
            this.employeeName = employeeName;
        }
        public void setSalary(double currentSalary)
        {
            this.currentSalary = currentSalary;
        }
        //Methods
        public void raiseSalary(double raiseAmount)
        {
            this.currentSalary += ((currentSalary * raiseAmount) / 100);
            Console.WriteLine("Salary raised. New Salary amount: " + getSalary());
        }
        public void Tax(double taxSalary)
        {
            Console.Write("Tax to pay: ");

            if (taxSalary == 0 && taxSalary <= 18200)
            {
                Console.WriteLine("Nil");
            }
            else if (taxSalary > 18200 && taxSalary <= 37000)
            {
                taxAmount = (taxSalary - 18200) * 0.19;
                Console.WriteLine(this.taxAmount.ToString("C"));
            }
            else if (taxSalary > 37000 && taxSalary <= 90000)
            {
                taxAmount = (3572 + (taxSalary - 37000) * 0.325);
                Console.WriteLine(this.taxAmount.ToString("C"));
            }
            else if (taxSalary > 90000 && taxSalary <= 180000)
            {
                taxAmount = (20797 + (taxSalary - 90000) * 0.37);
                Console.WriteLine(this.taxAmount.ToString("C"));
            }
            else if (taxSalary > 180000)
            {
                taxAmount = (54096 + (taxSalary - 180000) * 0.45);
                Console.WriteLine(this.taxAmount.ToString("C"));
            }
            else
            {
                Console.WriteLine("Invalid. Salary outside range");
            }
        }
    }
}

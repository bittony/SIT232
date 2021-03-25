using System;

namespace EmployeeProgram
{
    class EmployeeProgram
    {
        static void Main(string[] args)
        {
            Employee companyEmployee = new Employee("Sam", 40000);
            Console.WriteLine(companyEmployee.getName() + "\n" + companyEmployee.getSalary());
            companyEmployee.raiseSalary(30);
            companyEmployee.Tax(companyEmployee.returnSalary());

            Console.ReadLine();
            
            companyEmployee.setName("James");
            companyEmployee.setSalary(19000);
            Console.WriteLine(companyEmployee.getName() + "\n" + companyEmployee.getSalary());
            companyEmployee.Tax(companyEmployee.returnSalary());
            
            Console.WriteLine("Please enter the percentage to raise salary by: ");
            companyEmployee.raiseSalary(Convert.ToDouble(Console.ReadLine()));
            companyEmployee.Tax(companyEmployee.returnSalary());
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Employee
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }

    public class SalaryCalculator
    {
        public decimal CalculateYearlySalary(Employee employee)
        {
            return employee.Salary * 12;
        }
    }

    public class ReportGenerator
    {
        public void GenerateReport(Employee employee, string reportType)
        {
            // Code to generate report based on report type
            Console.WriteLine("Report");
        }
    }

    public class EmailService
    {
        public void SendNotification(string recipient, string message)
        {
            // Code to send email notification
            Console.WriteLine("Email sent to " + recipient);
        }
    }
}

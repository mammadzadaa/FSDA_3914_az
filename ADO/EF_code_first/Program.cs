using EF_code_first.Model;
using EF_code_first.Repository;
using System;
using System.Collections.Generic;

namespace EF_code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company()
            {
                Name = "StepIT",
                Address = "Koroglu Rahimov 70",
                AnnualIncome = 123443,
                DateEstablished = new DateTime(2016, 9, 1),
                Employees = new List<Employee>()
            };

            using var db = new ApplicationContext();

            var e = new Employee()
            {
                Name = "Mamed",
                Surname = "Mammadov",
                Salary = 550,
                Company = company,
                DateOfBirth = new DateTime(1990,5,12),
            };
            db.Companies.Add(company);
            db.Employees.Add(e);
            db.SaveChanges();
        }
    }
}

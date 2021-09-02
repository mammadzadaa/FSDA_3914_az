using System;
using System.Collections.Generic;
using System.Text;

namespace EF_code_first.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal? Salary { get; set; }
        public Company Company { get; set; }
    }
}

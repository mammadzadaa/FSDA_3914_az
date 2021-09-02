using System;
using System.Collections.Generic;
using System.Text;

namespace EF_code_first.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? DateEstablished { get; set; }
        public decimal? AnnualIncome { get; set; }
        public List<Employee> Employees { get; set; }
    }
}

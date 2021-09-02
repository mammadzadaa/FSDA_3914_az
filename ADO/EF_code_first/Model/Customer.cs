﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EF_code_first.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTimeOffset CreationTime { get; set; }
    }
}

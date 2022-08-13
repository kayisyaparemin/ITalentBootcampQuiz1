﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_One_To_Many.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_One_To_Many.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }
    }
}

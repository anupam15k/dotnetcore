﻿using System;
using System.Collections.Generic;

namespace CoreWebApplication.Models
{
    public partial class Employees
    {
        public long StudentId { get; set; }
        public string EmpName { get; set; }
        public int? EmpAge { get; set; }
        public string EmpCity { get; set; }
        public string EmpCountry { get; set; }
    }
}

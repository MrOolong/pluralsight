﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesConstructorsDemo
{
    public class Employee
    {
        // define properties below
        public int YearsOfService { get; set; }
        public int Office { get; set; }

        // define parameters of constructor
        public Employee(int years, int office)
        {
            YearsOfService = years;
            Office = office;
        }

        public Employee()
        {

        }

    }
}

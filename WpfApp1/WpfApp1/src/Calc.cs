﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.src
{
    class Calc
    {
        public double a;
        public double b;

        public double Add()
        {
            return a + b;
        }

        public double Sub()
        {
            return a - b;
        }

        public double Div()
        {
            return a / b;
        }

        public double Mult()
        {
            return a * b;
        }
    }
}

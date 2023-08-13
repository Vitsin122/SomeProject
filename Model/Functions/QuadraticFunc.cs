﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeProject.Model.Functions
{
    public class QuadraticFunc : IFunction
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public double Result { get; set; }
        public double Execute(double X, double Y) => Result = A * Math.Pow(X,2) + B*Y + C;
    }
}

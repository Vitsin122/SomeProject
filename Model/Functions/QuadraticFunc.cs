using System;

namespace SomeProject.Model.Functions
{
    public class QuadraticFunc : IFunction
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public double Result { get; set; }
        public double Execute(ref FuncArgs args) => args.Result = Result = A * Math.Pow(args.X,2) + B*args.Y + C;
        public QuadraticFunc() { }
    }
}
